namespace ClientUser
{
    partial class ClientUserForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientUserForm));
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.tbPort = new System.Windows.Forms.TextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.tbIPAddress = new System.Windows.Forms.TextBox();
            this.lblIPAddress = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblAnswerStatus = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbVar6 = new System.Windows.Forms.RadioButton();
            this.rbVar5 = new System.Windows.Forms.RadioButton();
            this.rbVar4 = new System.Windows.Forms.RadioButton();
            this.rbVar3 = new System.Windows.Forms.RadioButton();
            this.rbVar2 = new System.Windows.Forms.RadioButton();
            this.rbVar1 = new System.Windows.Forms.RadioButton();
            this.lblQuestionType = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCurrentQuestion = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnConfirmAnswer = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnGiveUp = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblTestName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.lblAnswers = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBegin = new System.Windows.Forms.Button();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalQuestions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lbTests = new System.Windows.Forms.ListBox();
            this.tbIsCompleted = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.gbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.btnConnect);
            this.gbConnection.Controls.Add(this.tbPort);
            this.gbConnection.Controls.Add(this.lblPort);
            this.gbConnection.Controls.Add(this.tbIPAddress);
            this.gbConnection.Controls.Add(this.lblIPAddress);
            this.gbConnection.Controls.Add(this.tbPassword);
            this.gbConnection.Controls.Add(this.lblPassword);
            this.gbConnection.Controls.Add(this.tbLogin);
            this.gbConnection.Controls.Add(this.lblLogin);
            this.gbConnection.Location = new System.Drawing.Point(4, 1);
            this.gbConnection.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbConnection.Name = "gbConnection";
            this.gbConnection.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbConnection.Size = new System.Drawing.Size(406, 115);
            this.gbConnection.TabIndex = 0;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection parameters";
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(166, 81);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(94, 28);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // tbPort
            // 
            this.tbPort.Location = new System.Drawing.Point(267, 54);
            this.tbPort.MaxLength = 50;
            this.tbPort.Name = "tbPort";
            this.tbPort.Size = new System.Drawing.Size(126, 21);
            this.tbPort.TabIndex = 7;
            this.tbPort.Text = "9001";
            this.tbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPort.Location = new System.Drawing.Point(223, 57);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(37, 15);
            this.lblPort.TabIndex = 6;
            this.lblPort.Text = "Port:";
            // 
            // tbIPAddress
            // 
            this.tbIPAddress.Location = new System.Drawing.Point(267, 27);
            this.tbIPAddress.MaxLength = 50;
            this.tbIPAddress.Name = "tbIPAddress";
            this.tbIPAddress.Size = new System.Drawing.Size(126, 21);
            this.tbIPAddress.TabIndex = 5;
            this.tbIPAddress.Text = "127.0.0.1";
            this.tbIPAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIPAddress
            // 
            this.lblIPAddress.AutoSize = true;
            this.lblIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblIPAddress.Location = new System.Drawing.Point(223, 30);
            this.lblIPAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIPAddress.Name = "lblIPAddress";
            this.lblIPAddress.Size = new System.Drawing.Size(24, 15);
            this.lblIPAddress.TabIndex = 4;
            this.lblIPAddress.Text = "IP:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(82, 54);
            this.tbPassword.MaxLength = 50;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(126, 21);
            this.tbPassword.TabIndex = 3;
            this.tbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPassword.Location = new System.Drawing.Point(2, 57);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(73, 15);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Password:";
            // 
            // tbLogin
            // 
            this.tbLogin.Location = new System.Drawing.Point(82, 27);
            this.tbLogin.MaxLength = 50;
            this.tbLogin.Name = "tbLogin";
            this.tbLogin.Size = new System.Drawing.Size(126, 21);
            this.tbLogin.TabIndex = 1;
            this.tbLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLogin.Location = new System.Drawing.Point(13, 30);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(49, 15);
            this.lblLogin.TabIndex = 0;
            this.lblLogin.Text = "Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblAnswerStatus);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblQuestionType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 116);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 391);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // lblAnswerStatus
            // 
            this.lblAnswerStatus.AutoSize = true;
            this.lblAnswerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerStatus.Location = new System.Drawing.Point(309, 170);
            this.lblAnswerStatus.Name = "lblAnswerStatus";
            this.lblAnswerStatus.Size = new System.Drawing.Size(46, 15);
            this.lblAnswerStatus.TabIndex = 5;
            this.lblAnswerStatus.Text = "NONE";
            this.lblAnswerStatus.Visible = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbAnswer);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(0, 315);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(406, 76);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "or";
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(127, 32);
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(266, 21);
            this.tbAnswer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your answer:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbVar6);
            this.groupBox3.Controls.Add(this.rbVar5);
            this.groupBox3.Controls.Add(this.rbVar4);
            this.groupBox3.Controls.Add(this.rbVar3);
            this.groupBox3.Controls.Add(this.rbVar2);
            this.groupBox3.Controls.Add(this.rbVar1);
            this.groupBox3.Location = new System.Drawing.Point(0, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(406, 136);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select answer:";
            // 
            // rbVar6
            // 
            this.rbVar6.AutoSize = true;
            this.rbVar6.Enabled = false;
            this.rbVar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar6.Location = new System.Drawing.Point(270, 95);
            this.rbVar6.Name = "rbVar6";
            this.rbVar6.Size = new System.Drawing.Size(30, 19);
            this.rbVar6.TabIndex = 5;
            this.rbVar6.Text = "-";
            this.rbVar6.UseVisualStyleBackColor = true;
            // 
            // rbVar5
            // 
            this.rbVar5.AutoSize = true;
            this.rbVar5.Enabled = false;
            this.rbVar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar5.Location = new System.Drawing.Point(270, 44);
            this.rbVar5.Name = "rbVar5";
            this.rbVar5.Size = new System.Drawing.Size(30, 19);
            this.rbVar5.TabIndex = 4;
            this.rbVar5.Text = "-";
            this.rbVar5.UseVisualStyleBackColor = true;
            // 
            // rbVar4
            // 
            this.rbVar4.AutoSize = true;
            this.rbVar4.Enabled = false;
            this.rbVar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar4.Location = new System.Drawing.Point(143, 95);
            this.rbVar4.Name = "rbVar4";
            this.rbVar4.Size = new System.Drawing.Size(30, 19);
            this.rbVar4.TabIndex = 3;
            this.rbVar4.Text = "-";
            this.rbVar4.UseVisualStyleBackColor = true;
            // 
            // rbVar3
            // 
            this.rbVar3.AutoSize = true;
            this.rbVar3.Enabled = false;
            this.rbVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar3.Location = new System.Drawing.Point(143, 44);
            this.rbVar3.Name = "rbVar3";
            this.rbVar3.Size = new System.Drawing.Size(30, 19);
            this.rbVar3.TabIndex = 2;
            this.rbVar3.Text = "-";
            this.rbVar3.UseVisualStyleBackColor = true;
            // 
            // rbVar2
            // 
            this.rbVar2.AutoSize = true;
            this.rbVar2.Enabled = false;
            this.rbVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar2.Location = new System.Drawing.Point(16, 95);
            this.rbVar2.Name = "rbVar2";
            this.rbVar2.Size = new System.Drawing.Size(30, 19);
            this.rbVar2.TabIndex = 1;
            this.rbVar2.Text = "-";
            this.rbVar2.UseVisualStyleBackColor = true;
            // 
            // rbVar1
            // 
            this.rbVar1.AutoSize = true;
            this.rbVar1.Checked = true;
            this.rbVar1.Enabled = false;
            this.rbVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar1.Location = new System.Drawing.Point(16, 44);
            this.rbVar1.Name = "rbVar1";
            this.rbVar1.Size = new System.Drawing.Size(30, 19);
            this.rbVar1.TabIndex = 0;
            this.rbVar1.TabStop = true;
            this.rbVar1.Text = "-";
            this.rbVar1.UseVisualStyleBackColor = true;
            // 
            // lblQuestionType
            // 
            this.lblQuestionType.AutoSize = true;
            this.lblQuestionType.Location = new System.Drawing.Point(92, 167);
            this.lblQuestionType.Name = "lblQuestionType";
            this.lblQuestionType.Size = new System.Drawing.Size(37, 15);
            this.lblQuestionType.TabIndex = 2;
            this.lblQuestionType.Text = "None";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Question type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCurrentQuestion);
            this.groupBox2.Location = new System.Drawing.Point(0, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(406, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current question:";
            // 
            // tbCurrentQuestion
            // 
            this.tbCurrentQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentQuestion.Location = new System.Drawing.Point(3, 17);
            this.tbCurrentQuestion.Multiline = true;
            this.tbCurrentQuestion.Name = "tbCurrentQuestion";
            this.tbCurrentQuestion.ReadOnly = true;
            this.tbCurrentQuestion.Size = new System.Drawing.Size(400, 128);
            this.tbCurrentQuestion.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnConfirmAnswer);
            this.groupBox5.Location = new System.Drawing.Point(409, 301);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 206);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // btnConfirmAnswer
            // 
            this.btnConfirmAnswer.Enabled = false;
            this.btnConfirmAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConfirmAnswer.Location = new System.Drawing.Point(44, 72);
            this.btnConfirmAnswer.Name = "btnConfirmAnswer";
            this.btnConfirmAnswer.Size = new System.Drawing.Size(126, 73);
            this.btnConfirmAnswer.TabIndex = 0;
            this.btnConfirmAnswer.Text = "Confirm Answer";
            this.btnConfirmAnswer.UseVisualStyleBackColor = true;
            this.btnConfirmAnswer.Click += new System.EventHandler(this.btnConfirmAnswer_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnGiveUp);
            this.groupBox6.Controls.Add(this.btnSubmit);
            this.groupBox6.Controls.Add(this.lblTestName);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.lblTotalQuestions);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.lblCorrectAnswers);
            this.groupBox6.Controls.Add(this.lblAnswers);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(621, 301);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(311, 206);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Test information:";
            // 
            // btnGiveUp
            // 
            this.btnGiveUp.Enabled = false;
            this.btnGiveUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGiveUp.Location = new System.Drawing.Point(181, 141);
            this.btnGiveUp.Name = "btnGiveUp";
            this.btnGiveUp.Size = new System.Drawing.Size(98, 51);
            this.btnGiveUp.TabIndex = 11;
            this.btnGiveUp.Text = "Give up";
            this.btnGiveUp.UseVisualStyleBackColor = true;
            this.btnGiveUp.Click += new System.EventHandler(this.btnGiveUp_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.Location = new System.Drawing.Point(29, 141);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 51);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestName.Location = new System.Drawing.Point(137, 31);
            this.lblTestName.Name = "lblTestName";
            this.lblTestName.Size = new System.Drawing.Size(40, 16);
            this.lblTestName.TabIndex = 9;
            this.lblTestName.Text = "None";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalQuestions.Location = new System.Drawing.Point(201, 72);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(35, 37);
            this.lblTotalQuestions.TabIndex = 7;
            this.lblTotalQuestions.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(158, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 55);
            this.label7.TabIndex = 6;
            this.label7.Text = "/";
            // 
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(137, 95);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(15, 16);
            this.lblCorrectAnswers.TabIndex = 5;
            this.lblCorrectAnswers.Text = "0";
            // 
            // lblAnswers
            // 
            this.lblAnswers.AutoSize = true;
            this.lblAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswers.Location = new System.Drawing.Point(137, 65);
            this.lblAnswers.Name = "lblAnswers";
            this.lblAnswers.Size = new System.Drawing.Size(15, 16);
            this.lblAnswers.TabIndex = 2;
            this.lblAnswers.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(26, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Correct:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Answered:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbQuestions);
            this.groupBox7.Location = new System.Drawing.Point(409, 1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 309);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Question selection";
            // 
            // lbQuestions
            // 
            this.lbQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.ItemHeight = 15;
            this.lbQuestions.Location = new System.Drawing.Point(3, 17);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(207, 289);
            this.lbQuestions.TabIndex = 0;
            this.lbQuestions.SelectedIndexChanged += new System.EventHandler(this.lbQuestions_SelectedIndexChanged);
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.lbTests);
            this.groupBox8.Location = new System.Drawing.Point(621, 1);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(311, 303);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Test selection";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.tbIsCompleted);
            this.groupBox9.Controls.Add(this.label6);
            this.groupBox9.Controls.Add(this.btnRefresh);
            this.groupBox9.Controls.Add(this.btnBegin);
            this.groupBox9.Controls.Add(this.tbTeacher);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.tbTotalQuestions);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(164, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(144, 283);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Info:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(6, 183);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 33);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBegin
            // 
            this.btnBegin.Enabled = false;
            this.btnBegin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnBegin.Location = new System.Drawing.Point(6, 222);
            this.btnBegin.Name = "btnBegin";
            this.btnBegin.Size = new System.Drawing.Size(132, 55);
            this.btnBegin.TabIndex = 13;
            this.btnBegin.Text = "Begin Test";
            this.btnBegin.UseVisualStyleBackColor = true;
            this.btnBegin.Click += new System.EventHandler(this.btnBegin_Click);
            // 
            // tbTeacher
            // 
            this.tbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTeacher.Location = new System.Drawing.Point(9, 85);
            this.tbTeacher.Name = "tbTeacher";
            this.tbTeacher.ReadOnly = true;
            this.tbTeacher.Size = new System.Drawing.Size(126, 22);
            this.tbTeacher.TabIndex = 12;
            this.tbTeacher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(6, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Teacher:";
            // 
            // tbTotalQuestions
            // 
            this.tbTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalQuestions.Location = new System.Drawing.Point(9, 40);
            this.tbTotalQuestions.Name = "tbTotalQuestions";
            this.tbTotalQuestions.ReadOnly = true;
            this.tbTotalQuestions.Size = new System.Drawing.Size(126, 22);
            this.tbTotalQuestions.TabIndex = 10;
            this.tbTotalQuestions.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(6, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "# of questions:";
            // 
            // lbTests
            // 
            this.lbTests.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTests.FormattingEnabled = true;
            this.lbTests.ItemHeight = 15;
            this.lbTests.Location = new System.Drawing.Point(3, 17);
            this.lbTests.Name = "lbTests";
            this.lbTests.Size = new System.Drawing.Size(161, 283);
            this.lbTests.TabIndex = 0;
            this.lbTests.SelectedIndexChanged += new System.EventHandler(this.lbTests_SelectedIndexChanged);
            // 
            // tbIsCompleted
            // 
            this.tbIsCompleted.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbIsCompleted.Location = new System.Drawing.Point(9, 131);
            this.tbIsCompleted.Name = "tbIsCompleted";
            this.tbIsCompleted.ReadOnly = true;
            this.tbIsCompleted.Size = new System.Drawing.Size(126, 22);
            this.tbIsCompleted.TabIndex = 17;
            this.tbIsCompleted.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(6, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Completed?";
            // 
            // ClientUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 510);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ClientUserForm";
            this.Text = "Testing System";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ClientUserForm_FormClosing);
            this.gbConnection.ResumeLayout(false);
            this.gbConnection.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCurrentQuestion;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbVar1;
        private System.Windows.Forms.RadioButton rbVar6;
        private System.Windows.Forms.RadioButton rbVar5;
        private System.Windows.Forms.RadioButton rbVar4;
        private System.Windows.Forms.RadioButton rbVar3;
        private System.Windows.Forms.RadioButton rbVar2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnConfirmAnswer;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblAnswers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Button btnGiveUp;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTotalQuestions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListBox lbTests;
        private System.Windows.Forms.Button btnBegin;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblAnswerStatus;
        private System.Windows.Forms.TextBox tbIsCompleted;
        private System.Windows.Forms.Label label6;
    }
}

