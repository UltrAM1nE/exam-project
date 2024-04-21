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
using ClientViewResults;

namespace ClientTeacher
{
    public partial class ClientTestEditorForm : Form
    {
        private int _port;
        private IPAddress _ip;

        private TcpClient _client;
        private BinaryFormatter _bf;

        private bool _isConnected = false;
        string _userName = string.Empty;

        private List<Test> _tests;
        public ClientTestEditorForm()
        {
            InitializeComponent();
            _bf = new BinaryFormatter();
            _tests = new List<Test>();
            cbIsAvailable.Items.Add(true);
            cbIsAvailable.Items.Add(false);
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
                            IsTeacher = true
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
                        btnViewResults.Visible = true;
                        btnSubmit.Enabled = true;
                        btnVarAnswerTip.Enabled = true;
                        btnTextAnswerTip.Enabled = true;
                        btnAvailabilityTip.Enabled = true;

                        tbLogin.ReadOnly = true;
                        tbPassword.ReadOnly = true;
                        tbIPAddress.ReadOnly = true;
                        tbPort.ReadOnly = true;
                        tbNewTestName.ReadOnly = false;
                        tbCurrentQuestion.ReadOnly = false;
                        tbVar1.ReadOnly = false;
                        tbVar2.ReadOnly = false;
                        tbVar3.ReadOnly = false;
                        tbVar4.ReadOnly = false;
                        tbVar5.ReadOnly = false;
                        tbVar6.ReadOnly = false;

                        rbVariantBased.Enabled = true;
                        rbTextBased.Enabled = true;

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
                btnViewResults.Visible = false;
                btnSubmit.Enabled = false;
                btnVarAnswerTip.Enabled = false;
                btnTextAnswerTip.Enabled = false;
                btnAvailabilityTip.Enabled = false;

                tbLogin.ReadOnly = false;
                tbPassword.ReadOnly = false;
                tbIPAddress.ReadOnly = false;
                tbPort.ReadOnly = false;
                tbNewTestName.ReadOnly = true;
                tbAnswer.ReadOnly = true;
                tbCurrentQuestion.ReadOnly = true;
                tbVar1.ReadOnly = true;
                tbVar2.ReadOnly = true;
                tbVar3.ReadOnly = true;
                tbVar4.ReadOnly = true;
                tbVar5.ReadOnly = true;
                tbVar6.ReadOnly = true;

                lbTests.DataSource = null;
                lbQuestions.DataSource = null;

                rbVariantBased.Enabled = false;
                rbTextBased.Enabled = false;

                _userName = string.Empty;
                _isConnected = false;
            }
        }

        private async void btnSubmit_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbNewTestName.Text))
            {
                MessageBox.Show("Name field is empty.", "Failed to create a test!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var request = new MyRequest()
            {
                Header = "CREATE-TEST",
                Test = new Test()
                {
                    Name = tbNewTestName.Text,
                    TeacherName = _userName,
                    IsAvaivable = false
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
            if (responce.ServerMessage == "CREATED")
                MessageBox.Show($"Test '{tbNewTestName.Text}' was successfully created.", "Created!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Test with this name already exists.", "Failed to create a test!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            tbNewTestName.Clear();
            ns.Close();
            _client.Close();

            btnRefresh_Click(null, null);
        }

        private async void btnCreate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCurrentQuestion.Text) || string.IsNullOrWhiteSpace(tbQuestionName.Text))
            {
                MessageBox.Show("Question name/text is empty.", "Failed to create a question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool isTextBased = rbTextBased.Checked;
            MyRequest request = new MyRequest();

            if (isTextBased)
            {
                if (string.IsNullOrWhiteSpace(tbAnswer.Text))
                {
                    MessageBox.Show("Answer is empty.", "Failed to create a question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var test = lbTests.SelectedItem as Test;
                request = new MyRequest()
                {
                    Header = "CREATE-QUESTION",
                    Question = new Question()
                    {
                        Name = tbQuestionName.Text,
                        TestId = test.Id,
                        QuestionText = tbCurrentQuestion.Text,
                        IsTextBased = true,
                        TextAnswer = tbAnswer.Text
                    }
                };
            }
            else
            {
                int count = 0;
                int correctVar = 0;
                if (!string.IsNullOrWhiteSpace(tbVar1.Text))
                {
                    count++;
                    if (rbVar1.Checked)
                        correctVar = 1;
                }
                if (!string.IsNullOrWhiteSpace(tbVar2.Text))
                {
                    count++;
                    if (rbVar2.Checked)
                        correctVar = 2;
                }
                if (!string.IsNullOrWhiteSpace(tbVar3.Text))
                {
                    count++;
                    if (rbVar3.Checked)
                        correctVar = 3;
                }
                if (!string.IsNullOrWhiteSpace(tbVar4.Text))
                {
                    count++;
                    if (rbVar4.Checked)
                        correctVar = 4;
                }
                if (!string.IsNullOrWhiteSpace(tbVar5.Text))
                {
                    count++;
                    if (rbVar5.Checked)
                        correctVar = 5;
                }
                if (!string.IsNullOrWhiteSpace(tbVar6.Text))
                {
                    count++;
                    if (rbVar6.Checked)
                        correctVar = 6;
                }
                if (count < 2)
                {
                    MessageBox.Show("Question must have at least 2 answer variants.", "Failed to create a question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (correctVar == 0)
                {
                    MessageBox.Show("Correct answer must be selected active answer.", "Failed to create a question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                var test = lbTests.SelectedItem as Test;
                request = new MyRequest()
                {
                    Header = "CREATE-QUESTION",
                    Question = new Question()
                    {
                        Name = tbQuestionName.Text,
                        TestId = test.Id,
                        QuestionText = tbCurrentQuestion.Text,
                        IsTextBased = false,
                        Var1Answer = tbVar1.Text,
                        Var2Answer = tbVar2.Text,
                        Var3Answer = tbVar3.Text,
                        Var4Answer = tbVar4.Text,
                        Var5Answer = tbVar5.Text,
                        Var6Answer = tbVar6.Text,
                        CorrectVar = correctVar
                    }
                };
            }



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
            if (responce.ServerMessage == "CREATED")
                MessageBox.Show($"Question '{tbQuestionName.Text}' was successfully created.", "Created!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unknwon error occured while creating question.", "Failed to create a question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

            tbQuestionName.Clear();
            tbCurrentQuestion.Clear();
            tbAnswer.Clear();
            tbVar1.Clear();
            tbVar2.Clear();
            tbVar3.Clear();
            tbVar4.Clear();
            tbVar5.Clear();
            tbVar6.Clear();
            ns.Close();
            _client.Close();

            btnRefresh_Click(null, null);
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            int selectedTestIndex = lbTests.SelectedIndex;
            int selectedQuestionIndex = lbQuestions.SelectedIndex;

            var request = new MyRequest()
            {
                Header = "GET",
                AuthUser = new User()
                { 
                    Login = _userName,
                    IsTeacher = true
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

            if(lbTests.Items.Count == 0)
            {
                lbTests.DataSource = null;
                lbQuestions.DataSource = null;

                tbTeacher.Text = string.Empty;
                tbTotalQuestions.Text = string.Empty;
                btnDelete.Enabled = false;
                btnCreate.Enabled = false;
                btnSetAvailability.Enabled = false;
                tbQuestionName.ReadOnly = true;
                cbIsAvailable.Enabled = false;
            }
            else
            {
                if (selectedTestIndex != -1 && lbTests.Items.Count > selectedTestIndex)
                    lbTests.SelectedIndex = selectedTestIndex;
                if(selectedQuestionIndex != -1 && lbQuestions.Items.Count > selectedQuestionIndex)
                    lbQuestions.SelectedIndex = selectedQuestionIndex;
            }
        }


        private void lbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            Test test = lbTests.SelectedItem as Test;

            if(test != null)
            {
                tbTeacher.Text = test.TeacherName;
                tbTotalQuestions.Text = test.Questions.Count.ToString();
                cbIsAvailable.Enabled = true;

                if (test.TeacherName == _userName)
                    btnSetAvailability.Enabled = true;
                else
                    btnSetAvailability.Enabled = false;
                if (test.IsAvaivable)
                {
                    cbIsAvailable.SelectedItem = true;
                    btnDelete.Enabled = false;
                    btnCreate.Enabled = false;
                    tbQuestionName.ReadOnly = true;
                }
                else
                {
                    cbIsAvailable.SelectedItem = false;

                    if (test.TeacherName == _userName)
                    {
                        btnDelete.Enabled = true;
                        btnCreate.Enabled = true;
                        tbQuestionName.ReadOnly = false;
                    }
                    else
                    {
                        btnDelete.Enabled = false;
                        btnCreate.Enabled = false;
                        tbQuestionName.ReadOnly = true;
                    }
                }

                if (test.Questions.Count > 0 && !test.IsAvaivable)
                    lbQuestions.DataSource = test.Questions;
                else 
                { 
                    lbQuestions.DataSource = null;

                    btnClear_Click(null, null);
                }
            }
            else
            {
                tbTeacher.Text = string.Empty;
                tbTotalQuestions.Text = string.Empty;
                btnDelete.Enabled = false;
                btnCreate.Enabled = false;
                btnSetAvailability.Enabled = false;
                tbQuestionName.ReadOnly = true;
                cbIsAvailable.Enabled = false;
                lbQuestions.DataSource = null;
            }
        }

        private void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Question question = lbQuestions.SelectedItem as Question;

            if(question != null)
            {
                btnClear_Click(null, null);
                tbCurrentQuestion.Text = question.QuestionText;
                if(question.IsTextBased)
                {
                    rbTextBased.Checked = true;
                    tbAnswer.Text = question.TextAnswer;
                    tbVar1.Clear();
                    tbVar2.Clear();
                    tbVar3.Clear();
                    tbVar4.Clear();
                    tbVar5.Clear();
                    tbVar6.Clear();
                }
                else
                {
                    rbVariantBased.Checked = true;
                    if(!string.IsNullOrWhiteSpace(question.Var1Answer))
                        tbVar1.Text = question.Var1Answer;
                    if (!string.IsNullOrWhiteSpace(question.Var2Answer))
                        tbVar2.Text = question.Var2Answer;
                    if (!string.IsNullOrWhiteSpace(question.Var3Answer))
                        tbVar3.Text = question.Var3Answer;
                    if (!string.IsNullOrWhiteSpace(question.Var4Answer))
                        tbVar4.Text = question.Var4Answer;
                    if (!string.IsNullOrWhiteSpace(question.Var5Answer))
                        tbVar5.Text = question.Var5Answer;
                    if (!string.IsNullOrWhiteSpace(question.Var6Answer))
                        tbVar6.Text = question.Var6Answer;
                    if (question.CorrectVar == 1)
                        rbVar1.Checked = true;
                    if (question.CorrectVar == 2)
                        rbVar2.Checked = true;
                    if (question.CorrectVar == 3)
                        rbVar3.Checked = true;
                    if (question.CorrectVar == 4)
                        rbVar4.Checked = true;
                    if (question.CorrectVar == 5)
                        rbVar5.Checked = true;
                    if (question.CorrectVar == 6)
                        rbVar6.Checked = true;
                    tbAnswer.Clear();
                }
                if (!(bool)cbIsAvailable.SelectedItem)
                    btnRemove.Enabled = true;
                else
                    btnRemove.Enabled = false;
            }
            else
            {
                tbCurrentQuestion.Clear();
                tbAnswer.Clear();
                tbVar1.Clear();
                tbVar2.Clear();
                tbVar3.Clear();
                tbVar4.Clear();
                tbVar5.Clear();
                tbVar6.Clear();
                btnRemove.Enabled = false;
            }
        }

        private void rbVariantBased_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVariantBased.Checked)
            {
                tbVar1.ReadOnly = false;
                tbVar2.ReadOnly = false;
                tbVar3.ReadOnly = false;
                tbVar4.ReadOnly = false;
                tbVar5.ReadOnly = false;
                tbVar6.ReadOnly = false;
                tbAnswer.ReadOnly = true;
            }
            else
            {
                tbVar1.ReadOnly = true;
                tbVar2.ReadOnly = true;
                tbVar3.ReadOnly = true;
                tbVar4.ReadOnly = true;
                tbVar5.ReadOnly = true;
                tbVar6.ReadOnly = true;
                tbAnswer.ReadOnly = false;
            }
        }

        private async void btnSetAvailability_Click(object sender, EventArgs e)
        {
            Test test = lbTests.SelectedItem as Test;
            if(test.IsAvaivable == (bool)cbIsAvailable.SelectedItem)
            {
                MessageBox.Show($"Avaivability status is already {(bool)cbIsAvailable.SelectedItem}.", "Update isn't necessary!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var request = new MyRequest()
            {
                Header = "SET-AVAIVABILITY",
                Test = new Test()
                {
                    Id = test.Id,
                    IsAvaivable = (bool)cbIsAvailable.SelectedItem
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
            if (responce.ServerMessage == "SUCCESS")
                MessageBox.Show($"Status updated to {(bool)cbIsAvailable.SelectedItem}.", "Updated!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unknwon error occured while updating availability.", "Failed to update availability!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ns.Close();
            _client.Close();

            btnRefresh_Click(null, null);
        }

        private async void btnRemove_Click(object sender, EventArgs e)
        {
            Question question = lbQuestions.SelectedItem as Question;
            var request = new MyRequest()
            {
                Header = "REMOVE-QUESTION",
                Question = new Question()
                {
                    Id = question.Id
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
            if (responce.ServerMessage == "SUCCESS")
                MessageBox.Show($"Question removed.", "Removed!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("Unknwon error occured while removing question.", "Failed to remove question!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ns.Close();
            _client.Close();

            btnRefresh_Click(null, null);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            Test test = lbTests.SelectedItem as Test;
            var firstWarning = MessageBox.Show($"Are you really want to remove test '{test.Name}'?\n" +
                $"That will also delete all questions inside it.", "Confirmation.",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (firstWarning == DialogResult.OK)
            {
                var secondWarning = MessageBox.Show($"Are you REALLY want to remove test '{test.Name}'?\n" +
                $"This action cannot be undone.", "Final confirmation.",
                        MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (secondWarning != DialogResult.OK)
                    return;
            }
            else
                return;
            var request = new MyRequest()
            {
                Header = "REMOVE-TEST",
                Test = new Test()
                {
                    Id = test.Id
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
            if (responce.ServerMessage == "SUCCESS")
            {
                MessageBox.Show($"Test removed.", "Removed!",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Unknwon error occured while removing test.", "Failed to remove test!",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            ns.Close();
            _client.Close();

            btnRefresh_Click(null, null);
        }

        private void btnVarAnswerTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Enter text in one of the text-boxes to add answer.\n\n" +
                $"Empty text-boxes will not be counted as answer options.\n\n" +
                $"After clicking 'Create Question' button, selected variant will count as correct answer.\n\n" +
                $"There must be at least 2 answers, and the correct answer shouldn't be an empty answer.", "Variant-based question guide.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTextAnswerTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Enter text into the bottom text-box to set it as the answer.\n\n" +
                $"The user will have to enter the same text to answer the question correctly.\n\n" +
                $"Letter case does not matter.\n\n" +
                $"Notice: text-answer is limited to 50 symbols.", "Text-based question guide.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        
        private void btnAvailabilityTip_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"If availability is set to false, user can't see nor begin this test, and vice versa.\n\n" +
                $"While test availability is set to true, you can't edit or delete it.\n\n" +
                $"If you a task owner, you can select opposite status in combo-box and click 'Set Availability' to change it.\n\n" +
                $"Users still can complete your task after setting availability to false, " +
                $"if they didn't refresh they task list after it", "Availability status guide.",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnViewResults_Click(object sender, EventArgs e)
        {
            if (ClientViewResultsForm.IsViewFormOpened)
                return;
            var viewResults = new ClientViewResultsForm(_ip, _port, _userName);
            ClientViewResultsForm.IsViewFormOpened = true;
            viewResults.Show();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbVariantBased.Checked = true;
            rbVar1.Checked = true;
            tbCurrentQuestion.Clear();
            tbAnswer.Clear();
            tbVar1.Clear();
            tbVar2.Clear();
            tbVar3.Clear();
            tbVar4.Clear();
            tbVar5.Clear();
            tbVar6.Clear();
            tbQuestionName.Clear();
        }
    }
}
