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

namespace ClientViewResults
{

    public partial class ClientViewResultsForm : Form
    {
        private readonly int _port;
        private readonly IPAddress _ip;
        private readonly string _userName;

        private TcpClient _client;
        private BinaryFormatter _bf;

        public static bool IsViewFormOpened = false;

        public ClientViewResultsForm()
        {
            InitializeComponent();
            _bf = new BinaryFormatter();
        }
        public ClientViewResultsForm(IPAddress ip, int port, string userName)
        {
            InitializeComponent();
            _bf = new BinaryFormatter();
            _ip = ip;
            _port = port;
            _userName = userName;
        }

        private void lbTests_SelectedIndexChanged(object sender, EventArgs e)
        {
            CompletedTest test = lbTests.SelectedItem as CompletedTest;

            if (test != null)
            {
                tbCompletedBy.Text = test.UserLogin;
                tbTotalQuestions.Text = test.Questions.Count.ToString();
                if (test.Questions.Count > 0)
                    lbQuestions.DataSource = test.Questions;
                lblTestName.Text = test.Name;
                lblCorrectAnswers.Text = test.Correct.ToString();
                lblTotalQuestions.Text = test.Questions.Count.ToString();
            }
            else
            {
                tbCompletedBy.Text = string.Empty;
                tbTotalQuestions.Text = string.Empty;
                lblTestName.Text = string.Empty;
                lblCorrectAnswers.Text = string.Empty;
                lblTotalQuestions.Text = string.Empty;
                lbQuestions.DataSource = null;
            }
        }

        private async void lbQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            var answeredQuestion = lbQuestions.SelectedItem as AnsweredQuestion;

            if (answeredQuestion != null)
            {
                var selectedTest = lbTests.SelectedItem as CompletedTest;
                List<Test> tempTestList = await GetTests();
                if (tempTestList == null)
                {
                    Close();
                    return;
                }
                var test = (from i in tempTestList
                            where i.Id == selectedTest.TestId
                            select i).First();
                var question = (from i in test.Questions
                                where i.Id == answeredQuestion.Id
                                select i).First();
                tbAnswer.Clear();

                rbVar1.Text = "-";
                rbVar2.Text = "-";
                rbVar3.Text = "-";
                rbVar4.Text = "-";
                rbVar5.Text = "-";
                rbVar6.Text = "-";

                tbCurrentQuestion.Text = question.QuestionText;

                foreach (var q in selectedTest.Questions)
                {
                    if (question.Id == q.Id)
                    {
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
                            if (q.VarAnswer == -1)
                            {
                                lblAnswerStatus.Text = "GIVED UP";
                                tbAnswer.Text = "User gived up. Variant 1 was selected by default.";
                                rbVar1.Checked = true;
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
                            if (q.TextAnswer == "USER-GIVED-UP")
                            {
                                lblAnswerStatus.Text = "GIVED UP";
                                tbAnswer.Text = "User gived up.";
                            }
                        }
                        return;
                    }
                    else
                        lblAnswerStatus.Visible = false;
                }
            }
            else
            {
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

        private void ClientViewResultsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            IsViewFormOpened = false;
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            var request = new MyRequest()
            {
                Header = "GET-COMPLETED",
                AuthUser = new User()
                {
                    Login = _userName
                }
            };

            _client = new TcpClient();
            try { await _client.ConnectAsync(_ip, _port); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to connect!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Close();
                return;
            }
            NetworkStream ns = _client.GetStream();
            _bf.Serialize(ns, request);

            MyResponce responce = (MyResponce)_bf.Deserialize(ns);
            lbTests.DataSource = responce.CompletedTests;

            ns.Close();

            if (lbTests.Items.Count == 0)
            {
                lbTests.DataSource = null;
                lbQuestions.DataSource = null;

                tbCompletedBy.Text = string.Empty;
                tbTotalQuestions.Text = string.Empty;

                lblTestName.Text = "None";
                lblCorrectAnswers.Text = "0";
            }
        }

        private async Task<List<Test>> GetTests()
        {
            var request = new MyRequest()
            {
                Header = "GET",
                AuthUser = new User()
                {
                    Login = _userName,
                    IsTeacher = true
                }
            };
            _client.Close();
            _client = new TcpClient();
            try
            { await _client.ConnectAsync(_ip, _port); }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed to connect!",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }
            NetworkStream ns = _client.GetStream();
            _bf.Serialize(ns, request);

            MyResponce responce = (MyResponce)_bf.Deserialize(ns);

            ns.Close();
            _client.Close();

            return responce.Tests;
        }
    }
}
