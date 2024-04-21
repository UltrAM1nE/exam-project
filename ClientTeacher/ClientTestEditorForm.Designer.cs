namespace ClientTeacher
{
    partial class ClientTestEditorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientTestEditorForm));
            this.gbConnection = new System.Windows.Forms.GroupBox();
            this.btnViewResults = new System.Windows.Forms.Button();
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
            this.btnClear = new System.Windows.Forms.Button();
            this.rbTextBased = new System.Windows.Forms.RadioButton();
            this.rbVariantBased = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnTextAnswerTip = new System.Windows.Forms.Button();
            this.tbAnswer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnVarAnswerTip = new System.Windows.Forms.Button();
            this.tbVar6 = new System.Windows.Forms.TextBox();
            this.tbVar5 = new System.Windows.Forms.TextBox();
            this.tbVar4 = new System.Windows.Forms.TextBox();
            this.tbVar3 = new System.Windows.Forms.TextBox();
            this.tbVar2 = new System.Windows.Forms.TextBox();
            this.tbVar1 = new System.Windows.Forms.TextBox();
            this.rbVar6 = new System.Windows.Forms.RadioButton();
            this.rbVar5 = new System.Windows.Forms.RadioButton();
            this.rbVar4 = new System.Windows.Forms.RadioButton();
            this.rbVar3 = new System.Windows.Forms.RadioButton();
            this.rbVar2 = new System.Windows.Forms.RadioButton();
            this.rbVar1 = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbCurrentQuestion = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tbQuestionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.tbNewTestName = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnAvailabilityTip = new System.Windows.Forms.Button();
            this.btnSetAvailability = new System.Windows.Forms.Button();
            this.cbIsAvailable = new System.Windows.Forms.ComboBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.tbTeacher = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbTotalQuestions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTests = new System.Windows.Forms.ListBox();
            this.gbConnection.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbConnection
            // 
            this.gbConnection.Controls.Add(this.btnViewResults);
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
            this.gbConnection.TabIndex = 1;
            this.gbConnection.TabStop = false;
            this.gbConnection.Text = "Connection parameters";
            // 
            // btnViewResults
            // 
            this.btnViewResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnViewResults.Location = new System.Drawing.Point(0, 81);
            this.btnViewResults.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnViewResults.Name = "btnViewResults";
            this.btnViewResults.Size = new System.Drawing.Size(145, 28);
            this.btnViewResults.TabIndex = 8;
            this.btnViewResults.Text = "Open results window";
            this.btnViewResults.UseVisualStyleBackColor = true;
            this.btnViewResults.Visible = false;
            this.btnViewResults.Click += new System.EventHandler(this.btnViewResults_Click);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnConnect.Location = new System.Drawing.Point(166, 81);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tbPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tbIPAddress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tbPassword.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.tbLogin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.rbTextBased);
            this.groupBox1.Controls.Add(this.rbVariantBased);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 117);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(406, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Question";
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnClear.Location = new System.Drawing.Point(337, 166);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(62, 23);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // rbTextBased
            // 
            this.rbTextBased.AutoSize = true;
            this.rbTextBased.Enabled = false;
            this.rbTextBased.Location = new System.Drawing.Point(200, 167);
            this.rbTextBased.Name = "rbTextBased";
            this.rbTextBased.Size = new System.Drawing.Size(86, 19);
            this.rbTextBased.TabIndex = 6;
            this.rbTextBased.Text = "Text-based";
            this.rbTextBased.UseVisualStyleBackColor = true;
            // 
            // rbVariantBased
            // 
            this.rbVariantBased.AutoSize = true;
            this.rbVariantBased.Checked = true;
            this.rbVariantBased.Enabled = false;
            this.rbVariantBased.Location = new System.Drawing.Point(93, 167);
            this.rbVariantBased.Name = "rbVariantBased";
            this.rbVariantBased.Size = new System.Drawing.Size(101, 19);
            this.rbVariantBased.TabIndex = 5;
            this.rbVariantBased.TabStop = true;
            this.rbVariantBased.Text = "Variant-based";
            this.rbVariantBased.UseVisualStyleBackColor = true;
            this.rbVariantBased.CheckedChanged += new System.EventHandler(this.rbVariantBased_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnTextAnswerTip);
            this.groupBox4.Controls.Add(this.tbAnswer);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(0, 315);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(406, 76);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "or";
            // 
            // btnTextAnswerTip
            // 
            this.btnTextAnswerTip.Enabled = false;
            this.btnTextAnswerTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnTextAnswerTip.Location = new System.Drawing.Point(377, 32);
            this.btnTextAnswerTip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnTextAnswerTip.Name = "btnTextAnswerTip";
            this.btnTextAnswerTip.Size = new System.Drawing.Size(26, 21);
            this.btnTextAnswerTip.TabIndex = 3;
            this.btnTextAnswerTip.Text = "?";
            this.btnTextAnswerTip.UseVisualStyleBackColor = true;
            this.btnTextAnswerTip.Click += new System.EventHandler(this.btnTextAnswerTip_Click);
            // 
            // tbAnswer
            // 
            this.tbAnswer.Location = new System.Drawing.Point(127, 32);
            this.tbAnswer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbAnswer.MaxLength = 50;
            this.tbAnswer.Name = "tbAnswer";
            this.tbAnswer.ReadOnly = true;
            this.tbAnswer.Size = new System.Drawing.Size(245, 21);
            this.tbAnswer.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter your answer:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnVarAnswerTip);
            this.groupBox3.Controls.Add(this.tbVar6);
            this.groupBox3.Controls.Add(this.tbVar5);
            this.groupBox3.Controls.Add(this.tbVar4);
            this.groupBox3.Controls.Add(this.tbVar3);
            this.groupBox3.Controls.Add(this.tbVar2);
            this.groupBox3.Controls.Add(this.tbVar1);
            this.groupBox3.Controls.Add(this.rbVar6);
            this.groupBox3.Controls.Add(this.rbVar5);
            this.groupBox3.Controls.Add(this.rbVar4);
            this.groupBox3.Controls.Add(this.rbVar3);
            this.groupBox3.Controls.Add(this.rbVar2);
            this.groupBox3.Controls.Add(this.rbVar1);
            this.groupBox3.Location = new System.Drawing.Point(0, 185);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(406, 136);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Select answer:";
            // 
            // btnVarAnswerTip
            // 
            this.btnVarAnswerTip.Enabled = false;
            this.btnVarAnswerTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnVarAnswerTip.Location = new System.Drawing.Point(377, 13);
            this.btnVarAnswerTip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnVarAnswerTip.Name = "btnVarAnswerTip";
            this.btnVarAnswerTip.Size = new System.Drawing.Size(26, 21);
            this.btnVarAnswerTip.TabIndex = 11;
            this.btnVarAnswerTip.Text = "?";
            this.btnVarAnswerTip.UseVisualStyleBackColor = true;
            this.btnVarAnswerTip.Click += new System.EventHandler(this.btnVarAnswerTip_Click);
            // 
            // tbVar6
            // 
            this.tbVar6.Location = new System.Drawing.Point(290, 91);
            this.tbVar6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVar6.MaxLength = 50;
            this.tbVar6.Name = "tbVar6";
            this.tbVar6.ReadOnly = true;
            this.tbVar6.Size = new System.Drawing.Size(93, 21);
            this.tbVar6.TabIndex = 10;
            // 
            // tbVar5
            // 
            this.tbVar5.Location = new System.Drawing.Point(290, 40);
            this.tbVar5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVar5.MaxLength = 50;
            this.tbVar5.Name = "tbVar5";
            this.tbVar5.ReadOnly = true;
            this.tbVar5.Size = new System.Drawing.Size(93, 21);
            this.tbVar5.TabIndex = 9;
            // 
            // tbVar4
            // 
            this.tbVar4.Location = new System.Drawing.Point(163, 91);
            this.tbVar4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVar4.MaxLength = 50;
            this.tbVar4.Name = "tbVar4";
            this.tbVar4.ReadOnly = true;
            this.tbVar4.Size = new System.Drawing.Size(93, 21);
            this.tbVar4.TabIndex = 8;
            // 
            // tbVar3
            // 
            this.tbVar3.Location = new System.Drawing.Point(163, 40);
            this.tbVar3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVar3.MaxLength = 50;
            this.tbVar3.Name = "tbVar3";
            this.tbVar3.ReadOnly = true;
            this.tbVar3.Size = new System.Drawing.Size(93, 21);
            this.tbVar3.TabIndex = 7;
            // 
            // tbVar2
            // 
            this.tbVar2.Location = new System.Drawing.Point(36, 91);
            this.tbVar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVar2.MaxLength = 50;
            this.tbVar2.Name = "tbVar2";
            this.tbVar2.ReadOnly = true;
            this.tbVar2.Size = new System.Drawing.Size(93, 21);
            this.tbVar2.TabIndex = 6;
            // 
            // tbVar1
            // 
            this.tbVar1.Location = new System.Drawing.Point(36, 40);
            this.tbVar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbVar1.MaxLength = 50;
            this.tbVar1.Name = "tbVar1";
            this.tbVar1.ReadOnly = true;
            this.tbVar1.Size = new System.Drawing.Size(93, 21);
            this.tbVar1.TabIndex = 3;
            // 
            // rbVar6
            // 
            this.rbVar6.AutoSize = true;
            this.rbVar6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar6.Location = new System.Drawing.Point(270, 95);
            this.rbVar6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbVar6.Name = "rbVar6";
            this.rbVar6.Size = new System.Drawing.Size(14, 13);
            this.rbVar6.TabIndex = 5;
            this.rbVar6.UseVisualStyleBackColor = true;
            // 
            // rbVar5
            // 
            this.rbVar5.AutoSize = true;
            this.rbVar5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar5.Location = new System.Drawing.Point(270, 44);
            this.rbVar5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbVar5.Name = "rbVar5";
            this.rbVar5.Size = new System.Drawing.Size(14, 13);
            this.rbVar5.TabIndex = 4;
            this.rbVar5.UseVisualStyleBackColor = true;
            // 
            // rbVar4
            // 
            this.rbVar4.AutoSize = true;
            this.rbVar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar4.Location = new System.Drawing.Point(144, 95);
            this.rbVar4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbVar4.Name = "rbVar4";
            this.rbVar4.Size = new System.Drawing.Size(14, 13);
            this.rbVar4.TabIndex = 3;
            this.rbVar4.UseVisualStyleBackColor = true;
            // 
            // rbVar3
            // 
            this.rbVar3.AutoSize = true;
            this.rbVar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar3.Location = new System.Drawing.Point(144, 44);
            this.rbVar3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbVar3.Name = "rbVar3";
            this.rbVar3.Size = new System.Drawing.Size(14, 13);
            this.rbVar3.TabIndex = 2;
            this.rbVar3.UseVisualStyleBackColor = true;
            // 
            // rbVar2
            // 
            this.rbVar2.AutoSize = true;
            this.rbVar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar2.Location = new System.Drawing.Point(16, 95);
            this.rbVar2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbVar2.Name = "rbVar2";
            this.rbVar2.Size = new System.Drawing.Size(14, 13);
            this.rbVar2.TabIndex = 1;
            this.rbVar2.UseVisualStyleBackColor = true;
            // 
            // rbVar1
            // 
            this.rbVar1.AutoSize = true;
            this.rbVar1.Checked = true;
            this.rbVar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rbVar1.Location = new System.Drawing.Point(16, 44);
            this.rbVar1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rbVar1.Name = "rbVar1";
            this.rbVar1.Size = new System.Drawing.Size(14, 13);
            this.rbVar1.TabIndex = 0;
            this.rbVar1.TabStop = true;
            this.rbVar1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 167);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Question type:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbCurrentQuestion);
            this.groupBox2.Location = new System.Drawing.Point(0, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(406, 148);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Current question:";
            // 
            // tbCurrentQuestion
            // 
            this.tbCurrentQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbCurrentQuestion.Location = new System.Drawing.Point(4, 17);
            this.tbCurrentQuestion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbCurrentQuestion.MaxLength = 500;
            this.tbCurrentQuestion.Multiline = true;
            this.tbCurrentQuestion.Name = "tbCurrentQuestion";
            this.tbCurrentQuestion.ReadOnly = true;
            this.tbCurrentQuestion.Size = new System.Drawing.Size(398, 128);
            this.tbCurrentQuestion.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbQuestions);
            this.groupBox7.Location = new System.Drawing.Point(409, 1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 302);
            this.groupBox7.TabIndex = 5;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Question managment";
            // 
            // lbQuestions
            // 
            this.lbQuestions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbQuestions.FormattingEnabled = true;
            this.lbQuestions.ItemHeight = 15;
            this.lbQuestions.Location = new System.Drawing.Point(3, 17);
            this.lbQuestions.Name = "lbQuestions";
            this.lbQuestions.Size = new System.Drawing.Size(207, 282);
            this.lbQuestions.TabIndex = 0;
            this.lbQuestions.SelectedIndexChanged += new System.EventHandler(this.lbQuestions_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tbQuestionName);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.btnRemove);
            this.groupBox5.Controls.Add(this.btnCreate);
            this.groupBox5.Location = new System.Drawing.Point(409, 302);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(213, 205);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // tbQuestionName
            // 
            this.tbQuestionName.Location = new System.Drawing.Point(79, 20);
            this.tbQuestionName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbQuestionName.MaxLength = 50;
            this.tbQuestionName.Name = "tbQuestionName";
            this.tbQuestionName.ReadOnly = true;
            this.tbQuestionName.Size = new System.Drawing.Size(126, 21);
            this.tbQuestionName.TabIndex = 9;
            this.tbQuestionName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Name:";
            // 
            // btnRemove
            // 
            this.btnRemove.Enabled = false;
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.btnRemove.Location = new System.Drawing.Point(44, 171);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(126, 28);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Enabled = false;
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCreate.Location = new System.Drawing.Point(44, 73);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(126, 73);
            this.btnCreate.TabIndex = 0;
            this.btnCreate.Text = "Create Question";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.tbNewTestName);
            this.groupBox6.Controls.Add(this.btnSubmit);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Location = new System.Drawing.Point(621, 302);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(311, 205);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Test creation:";
            // 
            // tbNewTestName
            // 
            this.tbNewTestName.Location = new System.Drawing.Point(110, 70);
            this.tbNewTestName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbNewTestName.MaxLength = 50;
            this.tbNewTestName.Name = "tbNewTestName";
            this.tbNewTestName.ReadOnly = true;
            this.tbNewTestName.Size = new System.Drawing.Size(126, 21);
            this.tbNewTestName.TabIndex = 8;
            this.tbNewTestName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Enabled = false;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSubmit.Location = new System.Drawing.Point(107, 142);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(98, 51);
            this.btnSubmit.TabIndex = 10;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(26, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Name:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.groupBox9);
            this.groupBox8.Controls.Add(this.lbTests);
            this.groupBox8.Location = new System.Drawing.Point(621, 1);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(311, 303);
            this.groupBox8.TabIndex = 8;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Test selection";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnAvailabilityTip);
            this.groupBox9.Controls.Add(this.btnSetAvailability);
            this.groupBox9.Controls.Add(this.cbIsAvailable);
            this.groupBox9.Controls.Add(this.btnRefresh);
            this.groupBox9.Controls.Add(this.btnDelete);
            this.groupBox9.Controls.Add(this.tbTeacher);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.tbTotalQuestions);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(164, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(144, 283);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Info:";
            // 
            // btnAvailabilityTip
            // 
            this.btnAvailabilityTip.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAvailabilityTip.Location = new System.Drawing.Point(109, 22);
            this.btnAvailabilityTip.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAvailabilityTip.Name = "btnAvailabilityTip";
            this.btnAvailabilityTip.Size = new System.Drawing.Size(26, 21);
            this.btnAvailabilityTip.TabIndex = 12;
            this.btnAvailabilityTip.Text = "?";
            this.btnAvailabilityTip.UseVisualStyleBackColor = true;
            this.btnAvailabilityTip.Click += new System.EventHandler(this.btnAvailabilityTip_Click);
            // 
            // btnSetAvailability
            // 
            this.btnSetAvailability.Enabled = false;
            this.btnSetAvailability.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnSetAvailability.Location = new System.Drawing.Point(6, 167);
            this.btnSetAvailability.Name = "btnSetAvailability";
            this.btnSetAvailability.Size = new System.Drawing.Size(132, 33);
            this.btnSetAvailability.TabIndex = 17;
            this.btnSetAvailability.Text = "Set Avilability";
            this.btnSetAvailability.UseVisualStyleBackColor = true;
            this.btnSetAvailability.Click += new System.EventHandler(this.btnSetAvailability_Click);
            // 
            // cbIsAvailable
            // 
            this.cbIsAvailable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsAvailable.Enabled = false;
            this.cbIsAvailable.FormattingEnabled = true;
            this.cbIsAvailable.Location = new System.Drawing.Point(9, 46);
            this.cbIsAvailable.Name = "cbIsAvailable";
            this.cbIsAvailable.Size = new System.Drawing.Size(126, 23);
            this.cbIsAvailable.TabIndex = 16;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Enabled = false;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(6, 244);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 33);
            this.btnRefresh.TabIndex = 15;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Enabled = false;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(6, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(132, 33);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // tbTeacher
            // 
            this.tbTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTeacher.Location = new System.Drawing.Point(9, 134);
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
            this.label10.Location = new System.Drawing.Point(6, 115);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 16);
            this.label10.TabIndex = 11;
            this.label10.Text = "Teacher:";
            // 
            // tbTotalQuestions
            // 
            this.tbTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbTotalQuestions.Location = new System.Drawing.Point(9, 90);
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
            this.label9.Location = new System.Drawing.Point(6, 71);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 16);
            this.label9.TabIndex = 9;
            this.label9.Text = "# of questions:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Avaivable:";
            // 
            // lbTests
            // 
            this.lbTests.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTests.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbTests.FormattingEnabled = true;
            this.lbTests.ItemHeight = 18;
            this.lbTests.Location = new System.Drawing.Point(3, 17);
            this.lbTests.Name = "lbTests";
            this.lbTests.Size = new System.Drawing.Size(161, 283);
            this.lbTests.TabIndex = 0;
            this.lbTests.SelectedIndexChanged += new System.EventHandler(this.lbTests_SelectedIndexChanged);
            // 
            // ClientTestEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 510);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbConnection);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ClientTestEditorForm";
            this.Text = "Testing System - Test Editor";
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
            this.groupBox7.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnection;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox tbPort;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.TextBox tbIPAddress;
        private System.Windows.Forms.Label lblIPAddress;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbAnswer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbVar6;
        private System.Windows.Forms.RadioButton rbVar5;
        private System.Windows.Forms.RadioButton rbVar4;
        private System.Windows.Forms.RadioButton rbVar3;
        private System.Windows.Forms.RadioButton rbVar2;
        private System.Windows.Forms.RadioButton rbVar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCurrentQuestion;
        private System.Windows.Forms.TextBox tbVar4;
        private System.Windows.Forms.TextBox tbVar3;
        private System.Windows.Forms.TextBox tbVar2;
        private System.Windows.Forms.TextBox tbVar1;
        private System.Windows.Forms.Button btnTextAnswerTip;
        private System.Windows.Forms.TextBox tbVar6;
        private System.Windows.Forms.TextBox tbVar5;
        private System.Windows.Forms.RadioButton rbTextBased;
        private System.Windows.Forms.RadioButton rbVariantBased;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNewTestName;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbTeacher;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbTotalQuestions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbTests;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnVarAnswerTip;
        private System.Windows.Forms.Button btnViewResults;
        private System.Windows.Forms.TextBox tbQuestionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbIsAvailable;
        private System.Windows.Forms.Button btnSetAvailability;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnAvailabilityTip;
    }
}

