namespace Q
{
    partial class Study
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.questionLabel = new System.Windows.Forms.Label();
            this.answerTextBox = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelStudy = new System.Windows.Forms.Panel();
            this.panelStudyResulte = new System.Windows.Forms.Panel();
            this.btnEndResult = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.studyScore = new System.Windows.Forms.Label();
            this.pictureNoCorrect = new System.Windows.Forms.PictureBox();
            this.pictureCorrect = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.remainingQuestion = new System.Windows.Forms.Label();
            this.panelStudy.SuspendLayout();
            this.panelStudyResulte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNoCorrect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // questionLabel
            // 
            this.questionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questionLabel.BackColor = System.Drawing.Color.White;
            this.questionLabel.Font = new System.Drawing.Font("MS UI Gothic", 60F);
            this.questionLabel.Location = new System.Drawing.Point(227, 72);
            this.questionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(613, 106);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // answerTextBox
            // 
            this.answerTextBox.Font = new System.Drawing.Font("MS UI Gothic", 30F);
            this.answerTextBox.Location = new System.Drawing.Point(308, 370);
            this.answerTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.answerTextBox.Name = "answerTextBox";
            this.answerTextBox.Size = new System.Drawing.Size(451, 57);
            this.answerTextBox.TabIndex = 1;
            this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTextBox_KeyPress);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btnNext.Location = new System.Drawing.Point(892, 464);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(125, 59);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "次の問題";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelStudy
            // 
            this.panelStudy.Controls.Add(this.remainingQuestion);
            this.panelStudy.Controls.Add(this.panelStudyResulte);
            this.panelStudy.Controls.Add(this.pictureNoCorrect);
            this.panelStudy.Controls.Add(this.pictureCorrect);
            this.panelStudy.Controls.Add(this.btnNext);
            this.panelStudy.Controls.Add(this.answerTextBox);
            this.panelStudy.Controls.Add(this.questionLabel);
            this.panelStudy.Controls.Add(this.btnBack);
            this.panelStudy.Location = new System.Drawing.Point(0, 0);
            this.panelStudy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStudy.Name = "panelStudy";
            this.panelStudy.Size = new System.Drawing.Size(1067, 564);
            this.panelStudy.TabIndex = 3;
            // 
            // panelStudyResulte
            // 
            this.panelStudyResulte.Controls.Add(this.btnEndResult);
            this.panelStudyResulte.Controls.Add(this.btnContinue);
            this.panelStudyResulte.Controls.Add(this.studyScore);
            this.panelStudyResulte.Location = new System.Drawing.Point(0, 0);
            this.panelStudyResulte.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelStudyResulte.Name = "panelStudyResulte";
            this.panelStudyResulte.Size = new System.Drawing.Size(1067, 564);
            this.panelStudyResulte.TabIndex = 3;
            this.panelStudyResulte.Visible = false;
            // 
            // btnEndResult
            // 
            this.btnEndResult.BackColor = System.Drawing.Color.White;
            this.btnEndResult.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnEndResult.Location = new System.Drawing.Point(427, 402);
            this.btnEndResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEndResult.Name = "btnEndResult";
            this.btnEndResult.Size = new System.Drawing.Size(213, 75);
            this.btnEndResult.TabIndex = 2;
            this.btnEndResult.Text = "終了";
            this.btnEndResult.UseVisualStyleBackColor = false;
            this.btnEndResult.Click += new System.EventHandler(this.btnEndResult_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.White;
            this.btnContinue.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.btnContinue.Location = new System.Drawing.Point(427, 288);
            this.btnContinue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(213, 75);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "もう一度";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // studyScore
            // 
            this.studyScore.AutoSize = true;
            this.studyScore.Font = new System.Drawing.Font("MS UI Gothic", 60F);
            this.studyScore.ForeColor = System.Drawing.Color.White;
            this.studyScore.Location = new System.Drawing.Point(431, 115);
            this.studyScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studyScore.Name = "studyScore";
            this.studyScore.Size = new System.Drawing.Size(192, 100);
            this.studyScore.TabIndex = 0;
            this.studyScore.Text = "1点";
            // 
            // pictureNoCorrect
            // 
            this.pictureNoCorrect.Image = global::Q.Properties.Resources._25508917;
            this.pictureNoCorrect.Location = new System.Drawing.Point(877, 4);
            this.pictureNoCorrect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureNoCorrect.Name = "pictureNoCorrect";
            this.pictureNoCorrect.Size = new System.Drawing.Size(185, 160);
            this.pictureNoCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureNoCorrect.TabIndex = 9;
            this.pictureNoCorrect.TabStop = false;
            // 
            // pictureCorrect
            // 
            this.pictureCorrect.Image = global::Q.Properties.Resources._24851426;
            this.pictureCorrect.Location = new System.Drawing.Point(892, 4);
            this.pictureCorrect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureCorrect.Name = "pictureCorrect";
            this.pictureCorrect.Size = new System.Drawing.Size(171, 160);
            this.pictureCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCorrect.TabIndex = 8;
            this.pictureCorrect.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.Font = new System.Drawing.Font("MS UI Gothic", 15F);
            this.btnBack.Location = new System.Drawing.Point(52, 464);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(125, 59);
            this.btnBack.TabIndex = 5;
            this.btnBack.Text = "戻る";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // remainingQuestion
            // 
            this.remainingQuestion.AutoSize = true;
            this.remainingQuestion.Font = new System.Drawing.Font("MS UI Gothic", 20F);
            this.remainingQuestion.ForeColor = System.Drawing.Color.White;
            this.remainingQuestion.Location = new System.Drawing.Point(12, 9);
            this.remainingQuestion.Name = "remainingQuestion";
            this.remainingQuestion.Size = new System.Drawing.Size(96, 34);
            this.remainingQuestion.TabIndex = 10;
            this.remainingQuestion.Text = "label1";
            // 
            // Study
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.panelStudy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Study";
            this.Text = "ConvenienceSoft";
            this.panelStudy.ResumeLayout(false);
            this.panelStudy.PerformLayout();
            this.panelStudyResulte.ResumeLayout(false);
            this.panelStudyResulte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureNoCorrect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCorrect)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelStudy;
        private System.Windows.Forms.Panel panelStudyResulte;
        private System.Windows.Forms.Label studyScore;
        private System.Windows.Forms.Button btnEndResult;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox pictureNoCorrect;
        private System.Windows.Forms.PictureBox pictureCorrect;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label remainingQuestion;
    }
}