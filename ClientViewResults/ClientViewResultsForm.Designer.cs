namespace ClientViewResults
{
    partial class ClientViewResultsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientViewResultsForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbQuestions = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tbTotalQuestions = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbCompletedBy = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTests = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.lblTotalQuestions = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTestName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCorrectAnswers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAnswerStatus = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.lblQuestionType);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(4, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(406, 391);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Questions";
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
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entered answer:";
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
            this.groupBox3.Text = "Selected answer:";
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
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbQuestions);
            this.groupBox7.Location = new System.Drawing.Point(409, 1);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(213, 309);
            this.groupBox7.TabIndex = 5;
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
            this.groupBox8.Size = new System.Drawing.Size(311, 309);
            this.groupBox8.TabIndex = 6;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Test selection";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.btnRefresh);
            this.groupBox9.Controls.Add(this.tbTotalQuestions);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.tbCompletedBy);
            this.groupBox9.Controls.Add(this.label8);
            this.groupBox9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox9.Location = new System.Drawing.Point(164, 17);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(144, 289);
            this.groupBox9.TabIndex = 1;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Info:";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(6, 168);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(132, 33);
            this.btnRefresh.TabIndex = 16;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
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
            // tbCompletedBy
            // 
            this.tbCompletedBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCompletedBy.Location = new System.Drawing.Point(9, 46);
            this.tbCompletedBy.Name = "tbCompletedBy";
            this.tbCompletedBy.ReadOnly = true;
            this.tbCompletedBy.Size = new System.Drawing.Size(126, 22);
            this.tbCompletedBy.TabIndex = 8;
            this.tbCompletedBy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(6, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Completed by:";
            // 
            // lbTests
            // 
            this.lbTests.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTests.FormattingEnabled = true;
            this.lbTests.ItemHeight = 15;
            this.lbTests.Location = new System.Drawing.Point(3, 17);
            this.lbTests.Name = "lbTests";
            this.lbTests.Size = new System.Drawing.Size(161, 289);
            this.lbTests.TabIndex = 0;
            this.lbTests.SelectedIndexChanged += new System.EventHandler(this.lbTests_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.lblTotalQuestions);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.lblTestName);
            this.groupBox6.Controls.Add(this.label4);
            this.groupBox6.Controls.Add(this.lblCorrectAnswers);
            this.groupBox6.Controls.Add(this.label2);
            this.groupBox6.Location = new System.Drawing.Point(409, 313);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(523, 199);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Test information:";
            // 
            // lblTotalQuestions
            // 
            this.lblTotalQuestions.AutoSize = true;
            this.lblTotalQuestions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTotalQuestions.Location = new System.Drawing.Point(194, 83);
            this.lblTotalQuestions.Name = "lblTotalQuestions";
            this.lblTotalQuestions.Size = new System.Drawing.Size(15, 16);
            this.lblTotalQuestions.TabIndex = 11;
            this.lblTotalQuestions.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(176, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(12, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "/";
            // 
            // lblTestName
            // 
            this.lblTestName.AutoSize = true;
            this.lblTestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTestName.Location = new System.Drawing.Point(155, 31);
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
            // lblCorrectAnswers
            // 
            this.lblCorrectAnswers.AutoSize = true;
            this.lblCorrectAnswers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCorrectAnswers.Location = new System.Drawing.Point(155, 83);
            this.lblCorrectAnswers.Name = "lblCorrectAnswers";
            this.lblCorrectAnswers.Size = new System.Drawing.Size(15, 16);
            this.lblCorrectAnswers.TabIndex = 2;
            this.lblCorrectAnswers.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(26, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Correct answers:";
            // 
            // lblAnswerStatus
            // 
            this.lblAnswerStatus.AutoSize = true;
            this.lblAnswerStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblAnswerStatus.Location = new System.Drawing.Point(309, 170);
            this.lblAnswerStatus.Name = "lblAnswerStatus";
            this.lblAnswerStatus.Size = new System.Drawing.Size(46, 15);
            this.lblAnswerStatus.TabIndex = 8;
            this.lblAnswerStatus.Text = "NONE";
            this.lblAnswerStatus.Visible = false;
            // 
            // ClientViewResultsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 510);
            this.Controls.Add(this.lblAnswerStatus);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ClientViewResultsForm";
            this.Text = "Testing System - Results Viewer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ClientViewResultsForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.Label lblQuestionType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbCurrentQuestion;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ListBox lbQuestions;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.TextBox tbTotalQuestions;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbCompletedBy;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbTests;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label lblTestName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCorrectAnswers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalQuestions;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAnswerStatus;
    }
}

