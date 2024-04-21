using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using static System.Net.Mime.MediaTypeNames;

namespace ClientUser
{
    public partial class ClientUserForm : Form
    {
        private int _port;
        private IPAddress _ip;

        private TcpClient _client;
        private BinaryFormatter _bf;

        private bool _isConnected = false;
        private bool _isTestStarted = false;
        private bool _isTestCompleted = false;
        private bool _isFormClosing = false;
        string _userName = string.Empty;

        private Test _currentTest;
        private CompletedTest _completedTest;

        private int _answers = 0;
        private int _correctAnswers = 0;

        public ClientUserForm()
        {
            InitializeComponent();
            _bf = new BinaryFormatter();
        }

        private async void btnConnect_Click(object sender, EventArgs e)
        {
            if (!_isConnected)
            {
                try
                {
                    _port = int.Parse(tbPort.Text);
                    _ip = IPAddress.Parse(tbIPAddress.Text);
                }
                catch
                {
                    MessageBox.Show("Unparseble value in IP or Port field", "Failed to connect!",
                       MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string login = tbLogin.Text;
                string pass = tbPassword.Text;

                if (string.IsNullOrWhiteSpace(login))
                    MessageBox.Show("Login field is empty.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (string.IsNullOrWhiteSpace(pass))
                    MessageBox.Show("Password field is empty.", "Warning!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    var request = new MyRequest()
                    {
                        Header = "AUTH",
                        AuthUser = new User()
                        {
                            Id = 0,
                            Login = login,
                            Password = pass,
                            IsTeacher = false
                        }
                    };

                    _client = new TcpClient();
                    try { await _client.ConnectAsync(_ip, _port); }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Failed to connect!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    NetworkStream ns = _client.GetStream();
                    _bf.Serialize(ns, request);

                    MyResponce responce = (MyResponce)_bf.Deserialize(ns);
                    string message = responce.ServerMessage;
                    if (message == "SUCCESS-AUTH" || message == "SUCCESS-CREATE")
                    {
                        if (message == "SUCCESS-AUTH")
                            MessageBox.Show($"Welcome, {login}!", "Logged in.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        else
                            MessageBox.Show($"Successfully created account '{login}'!", "Logged in.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                        btnConnect.Text = "Disconnect";
                        btnRefresh.Enabled = true;

                        tbLogin.ReadOnly = true;
                        tbPassword.ReadOnly = true;
                        tbIPAddress.ReadOnly = true;
                        tbPort.ReadOnly = true;

                        _userName = responce.UserName;
                        _isConnected = true;
                    }
                    else
                        MessageBox.Show("Login was taken/Incorrect password.", "Failed to authenticate!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                btnConnect.Text = "Connect";
                btnRefresh.Enabled = false;
                btnSubmit.Enabled = false;
                tbAnswer.ReadOnly = true;
                tbCurrentQuestion.ReadOnly = true;

                tbLogin.ReadOnly = false;
                tbPassword.ReadOnly = false;
                tbIPAddress.ReadOnly = false;
                tbPort.ReadOnly = false;

                lbTests.DataSource = null;
                lbQuestions.DataSource = null;

                _userName = string.Empty;
                _isConnected = false;
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            var request = new MyRequest()
            {
                Header = "GET",
                AuthUser = new User()
                {
                    Login = _userName,
                    IsTeacher = false
                }
            };

            _client = new TcpClient();
            try { await _client.ConnectAsync(_ip, _port); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to connect!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConnect_Click(null, null);
                return;
            }
            NetworkStream ns = _client.GetStream();
            _bf.Serialize(ns, request);

            MyResponce responce = (MyResponce)_bf.Deserialize(ns);
            lbTests.DataSource = responce.Tests;

            ns.Close();
            _client.Close();

            if (lbTests.Items.Count == 0)
            {
                lbTests.DataSource = null;
                lbQuestions.DataSource = null;
                btnBegin.Enabled = false;

                tbTeacher.Text = string.Empty;
                tbTotalQuestions.Text = string.Empty;
                tbIsCompleted.Text = string.Empty;
            }
        }

        private void lbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            Test test = lbTests.SelectedItem as Test;

            var request = new MyRequest()
            {
                Header = "GET-COMPLETED"
            };

            _client = new TcpClient();
            try
            { _client.Connect(_ip, _port); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to connect!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConnect_Click(null, null);
                return;
            }
            NetworkStream ns = _client.GetStream();
            _bf.Serialize(ns, request);

            MyResponce responce = (MyResponce)_bf.Deserialize(ns);

            var compTests = responce.CompletedTests ?? new List<CompletedTest>();

            ns.Close();
            _client.Close();

            

            if (test != null)
            {
                foreach (var ct in compTests)
                {
                    if (ct.TestId == test.Id && ct.UserLogin == _userName)
                    {
                        _isTestCompleted = true;
                        break;
                    }
                    else
                        _isTestCompleted = false;
                }

                tbTeacher.Text = test.TeacherName;
                tbTotalQuestions.Text = test.Questions.Count.ToString();
                tbIsCompleted.Text = _isTestCompleted.ToString();
                if (test.Questions.Count > 0)
                    btnBegin.Enabled = true;
            }
            else
            {
                tbTeacher.Text = string.Empty;
                tbTotalQuestions.Text = string.Empty;
                tbIsCompleted.Text = string.Empty;
                lbQuestions.DataSource = null;
                btnBegin.Enabled = false;
            }
        }

        private void btnBegin_Click(object sender, EventArgs e)
        {
            _currentTest = lbTests.SelectedItem as Test;

            if (_isTestCompleted)
            {
                MessageBox.Show("You have already completed this test.", "Failed to begin a test!",
            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var warning = MessageBox.Show($"Are you really want to begin test '{_currentTest.Name}'?\n" +
               $"You will have only one attempt.\n\n" +
               $"You can't disconnect during the test, closing the app will result in auto-giving up on test.", "Confirmation.",
                       MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (warning != DialogResult.OK)
                return;

            _completedTest = new CompletedTest
            {
                Questions = new List<AnsweredQuestion>(),
                TestId = _currentTest.Id,
                Name = _currentTest.Name,
                UserLogin = _userName
            };

            lbQuestions.DataSource = _currentTest.Questions;
            lbTests.Enabled = false;
            btnRefresh.Enabled = false;
            btnBegin.Enabled = false;
            btnConnect.Enabled = false;
            btnGiveUp.Enabled = true;

            lblTestName.Text = _currentTest.Name;
            lblTotalQuestions.Text = _currentTest.Questions.Count.ToString();

            _isTestStarted = true;
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question question = lbQuestions.SelectedItem as Question;

            if (question != null)
            {
                tbAnswer.Clear();

                rbVar1.Text = "-";
                rbVar2.Text = "-";
                rbVar3.Text = "-";
                rbVar4.Text = "-";
                rbVar5.Text = "-";
                rbVar6.Text = "-";
                rbVar1.Enabled = false;
                rbVar2.Enabled = false;
                rbVar3.Enabled = false;
                rbVar4.Enabled = false;
                rbVar5.Enabled = false;
                rbVar6.Enabled = false;

                foreach (var q in _completedTest.Questions)
                {
                    if (question.Id == q.Id)
                    {
                        btnConfirmAnswer.Enabled = false;
                        lblAnswerStatus.Visible = true;
                        if (q.IsCorrect)
                            lblAnswerStatus.Text = "CORRECT";
                        else
                            lblAnswerStatus.Text = "INCORRECT";
                        if (!question.IsTextBased)
                        {
                            lblQuestionType.Text = "Variant-based";
                            tbAnswer.ReadOnly = true;
                            if (!string.IsNullOrWhiteSpace(question.Var1Answer))
                            {
                                rbVar1.Text = question.Var1Answer;
                                if (q.VarAnswer == 1)
                                    rbVar1.Checked = true;
                            }
                            if (!string.IsNullOrWhiteSpace(question.Var2Answer))
                            {
                                rbVar2.Text = question.Var2Answer;
                                if (q.VarAnswer == 2)
                                    rbVar2.Checked = true;
                            }
                            if (!string.IsNullOrWhiteSpace(question.Var3Answer))
                            {
                                rbVar3.Text = question.Var3Answer;
                                if (q.VarAnswer == 3)
                                    rbVar3.Checked = true;
                            }
                            if (!string.IsNullOrWhiteSpace(question.Var4Answer))
                            {
                                rbVar4.Text = question.Var4Answer;
                                if (q.VarAnswer == 4)
                                    rbVar4.Checked = true;
                            }
                            if (!string.IsNullOrWhiteSpace(question.Var5Answer))
                            {
                                rbVar5.Text = question.Var5Answer;
                                if (q.VarAnswer == 5)
                                    rbVar5.Checked = true;
                            }
                            if (!string.IsNullOrWhiteSpace(question.Var6Answer))
                            {
                                rbVar6.Text = question.Var6Answer;
                                if (q.VarAnswer == 6)
                                    rbVar6.Checked = true;
                            }
                        }
                        else
                        {
                            lblQuestionType.Text = "Text-based";
                            rbVar1.Text = "-";
                            rbVar2.Text = "-";
                            rbVar3.Text = "-";
                            rbVar4.Text = "-";
                            rbVar5.Text = "-";
                            rbVar6.Text = "-";
                            tbAnswer.Text = q.TextAnswer;
                        }
                        return;
                    }
                    else
                        lblAnswerStatus.Visible = false;
                }
                tbCurrentQuestion.Text = question.QuestionText;
                btnConfirmAnswer.Enabled = true;
                if (question.IsTextBased)
                {
                    lblQuestionType.Text = "Text-based";
                    tbAnswer.ReadOnly = false;
                }
                else
                {
                    lblQuestionType.Text = "Variant-based";
                    if (!string.IsNullOrWhiteSpace(question.Var1Answer))
                    {
                        rbVar1.Text = question.Var1Answer;
                        rbVar1.Enabled = true;
                        rbVar1.Checked = true;
                    }
                    if (!string.IsNullOrWhiteSpace(question.Var2Answer))
                    {
                        rbVar2.Text = question.Var2Answer;
                        rbVar2.Enabled = true;
                        rbVar2.Checked = true;
                    }
                    if (!string.IsNullOrWhiteSpace(question.Var3Answer))
                    {
                        rbVar3.Text = question.Var3Answer;
                        rbVar3.Enabled = true;
                        rbVar3.Checked = true;
                    }
                    if (!string.IsNullOrWhiteSpace(question.Var4Answer))
                    {
                        rbVar4.Text = question.Var4Answer;
                        rbVar4.Enabled = true;
                        rbVar4.Checked = true;
                    }
                    if (!string.IsNullOrWhiteSpace(question.Var5Answer))
                    {
                        rbVar5.Text = question.Var5Answer;
                        rbVar5.Enabled = true;
                        rbVar5.Checked = true;
                    }
                    if (!string.IsNullOrWhiteSpace(question.Var6Answer))
                    {
                        rbVar6.Text = question.Var6Answer;
                        rbVar6.Enabled = true;
                        rbVar6.Checked = true;
                    }
                    tbAnswer.ReadOnly = true;
                }
            }
            else
            {
                rbVar1.Enabled = false;
                rbVar2.Enabled = false;
                rbVar3.Enabled = false;
                rbVar4.Enabled = false;
                rbVar5.Enabled = false;
                rbVar6.Enabled = false;
                rbVar1.Text = "-";
                rbVar2.Text = "-";
                rbVar3.Text = "-";
                rbVar4.Text = "-";
                rbVar5.Text = "-";
                rbVar6.Text = "-";
                lblQuestionType.Text = "None";
                lblAnswerStatus.Visible = false;
                tbAnswer.ReadOnly = true;
                tbAnswer.Clear();
                tbCurrentQuestion.Clear();
            }
        }

        private void btnConfirmAnswer_Click(object sender, EventArgs e)
        {
            Question question = lbQuestions.SelectedItem as Question;
            if ((string.IsNullOrWhiteSpace(tbAnswer.Text) && question.IsTextBased) || tbAnswer.Text == "USER-GIVED-UP")
            {
                MessageBox.Show("Answer is empty.", "Failed to answer a question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            AnsweredQuestion answer = new AnsweredQuestion()
            {
                Id = question.Id,
                CompletedTestId = _completedTest.Id,
                IsTextBased = question.IsTextBased,
                Name = question.Name
            };
            if(question.IsTextBased)
            {
                answer.TextAnswer = tbAnswer.Text;
                answer.VarAnswer = -1;
                if (answer.TextAnswer.ToLower() == question.TextAnswer.ToLower())
                {
                    answer.IsCorrect = true;
                    _correctAnswers++;
                }
                else
                    answer.IsCorrect = false;
                tbAnswer.ReadOnly = true;
            }
            else
            {
                answer.TextAnswer = "";
                if (rbVar1.Checked)
                    answer.VarAnswer = 1;
                if (rbVar2.Checked)
                    answer.VarAnswer = 2;
                if (rbVar3.Checked)
                    answer.VarAnswer = 3;
                if (rbVar4.Checked)
                    answer.VarAnswer = 4;
                if (rbVar5.Checked)
                    answer.VarAnswer = 5;
                if (rbVar6.Checked)
                    answer.VarAnswer = 6;

                if (answer.VarAnswer == question.CorrectVar)
                {
                    answer.IsCorrect = true;
                    _correctAnswers++;
                }
                else
                    answer.IsCorrect = false;
            }
            _completedTest.Questions.Add(answer);
            _answers++;
            lblAnswers.Text = _answers.ToString();
            lblCorrectAnswers.Text = _correctAnswers.ToString();
            if(_answers == lbQuestions.Items.Count)
            {
                btnSubmit.Enabled = true;
                btnGiveUp.Enabled = false;
            }
            lbQuestions_SelectedIndexChanged(null, null);
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            _completedTest.Correct = _correctAnswers;
            int answersBeforeGiveUp = _completedTest.Questions.Count;
            bool isGivedUp = false;

            if(sender == null && e == null)
            {
                isGivedUp = true;
                foreach (var question in _currentTest.Questions)
                {
                    bool check = false;
                    for (int i = 0; i < _completedTest.Questions.Count; i++)
                    {
                        if (question.Id == _completedTest.Questions.ElementAt(i).Id)
                            check = true;
                    }
                    if (!check)
                    {
                        _completedTest.Questions.Add(new AnsweredQuestion()
                        {
                            Id = question.Id,
                            CompletedTestId = _completedTest.Id,
                            IsTextBased = question.IsTextBased,
                            Name = question.Name,
                            TextAnswer = "USER-GIVED-UP",
                            VarAnswer = -1,
                            IsCorrect = false
                        });
                    }
                }
            }
            var request = new MyRequest()
            {
                Header = "COMPLETE-TEST",
                CompletedTest = _completedTest
            };

            _client = new TcpClient();
            try { await _client.ConnectAsync(_ip, _port); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to connect!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnConnect_Click(null, null);
                return;
            }
            NetworkStream ns = _client.GetStream();
            _bf.Serialize(ns, request);

            MyResponce responce = (MyResponce)_bf.Deserialize(ns);
            if (responce.ServerMessage == "SUCCESS")
            {
                if (!isGivedUp)
                    MessageBox.Show($"Test '{_completedTest.Name}' was successfully completed.\n\n" +
                    $"Correct answers: {_completedTest.Correct}/{_completedTest.Questions.Count}", "Completed!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                else if(!_isFormClosing)
                    MessageBox.Show($"You gave up on test '{_completedTest.Name}'.\n\n" +
                        $"Correct/Total answers: {_completedTest.Correct}/{answersBeforeGiveUp}", "Gave Up!",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                lbQuestions.DataSource = null;
                lbTests.Enabled = true;
                btnConnect.Enabled = true;
                btnRefresh.Enabled = true;
                btnBegin.Enabled = true;
                btnSubmit.Enabled = false;
                btnGiveUp.Enabled = false;

                lblTestName.Text = "None";
                lblAnswers.Text = "0";
                lblCorrectAnswers.Text = "0";
                lblTotalQuestions.Text = "0";

                _answers = 0;
                _correctAnswers = 0;
                _isTestStarted = false;
            }
            else
                MessageBox.Show("Unknwon error occured while completing the test.", "Failed to complete a test!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            ns.Close();
            _client.Close();
            if(responce.ServerMessage == "SUCCESS" && !_isFormClosing)
                btnRefresh_Click(null, null);
        }

        private void btnGiveUp_Click(object sender, EventArgs e)
        {
            btnSubmit_Click(null, null);
        }

        private void ClientUserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            _isFormClosing = true;
            if (_isTestStarted)
                btnSubmit_Click(null, null);
        }
    }
}
