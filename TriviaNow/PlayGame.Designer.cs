namespace TriviaNow
{
    partial class PlayGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayGame));
            this.questionTextLabel = new System.Windows.Forms.Label();
            this.choice4RadioButton = new System.Windows.Forms.RadioButton();
            this.choice3RadioButton = new System.Windows.Forms.RadioButton();
            this.choice2RadioButton = new System.Windows.Forms.RadioButton();
            this.choice1RadioButton = new System.Windows.Forms.RadioButton();
            this.checkButton = new System.Windows.Forms.Button();
            this.currentQuestionCountLabel = new System.Windows.Forms.Label();
            this.numberCorrectLabel = new System.Windows.Forms.Label();
            this.outOfThreeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.questionCountLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.nextButton = new System.Windows.Forms.Button();
            this.numberCorrectOutOf3Label = new System.Windows.Forms.Label();
            this.currentCorrectLabel = new System.Windows.Forms.Label();
            this.answerFeedbackLabel = new System.Windows.Forms.Label();
            this.questionFeedbackLabel = new System.Windows.Forms.Label();
            this.feedBackLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.AutoSize = true;
            this.questionTextLabel.Font = new System.Drawing.Font("Lucida Calligraphy", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTextLabel.ForeColor = System.Drawing.Color.Red;
            this.questionTextLabel.Location = new System.Drawing.Point(17, 54);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.Size = new System.Drawing.Size(132, 31);
            this.questionTextLabel.TabIndex = 0;
            this.questionTextLabel.Text = "Question";
            // 
            // choice4RadioButton
            // 
            this.choice4RadioButton.AutoSize = true;
            this.choice4RadioButton.ForeColor = System.Drawing.Color.Blue;
            this.choice4RadioButton.Location = new System.Drawing.Point(23, 198);
            this.choice4RadioButton.Name = "choice4RadioButton";
            this.choice4RadioButton.Size = new System.Drawing.Size(96, 24);
            this.choice4RadioButton.TabIndex = 3;
            this.choice4RadioButton.TabStop = true;
            this.choice4RadioButton.Tag = "4";
            this.choice4RadioButton.Text = "Choice 4";
            this.choice4RadioButton.UseVisualStyleBackColor = true;
            // 
            // choice3RadioButton
            // 
            this.choice3RadioButton.AutoSize = true;
            this.choice3RadioButton.ForeColor = System.Drawing.Color.Blue;
            this.choice3RadioButton.Location = new System.Drawing.Point(23, 167);
            this.choice3RadioButton.Name = "choice3RadioButton";
            this.choice3RadioButton.Size = new System.Drawing.Size(96, 24);
            this.choice3RadioButton.TabIndex = 2;
            this.choice3RadioButton.TabStop = true;
            this.choice3RadioButton.Tag = "3";
            this.choice3RadioButton.Text = "Choice 3";
            this.choice3RadioButton.UseVisualStyleBackColor = true;
            // 
            // choice2RadioButton
            // 
            this.choice2RadioButton.AutoSize = true;
            this.choice2RadioButton.ForeColor = System.Drawing.Color.Blue;
            this.choice2RadioButton.Location = new System.Drawing.Point(23, 136);
            this.choice2RadioButton.Name = "choice2RadioButton";
            this.choice2RadioButton.Size = new System.Drawing.Size(96, 24);
            this.choice2RadioButton.TabIndex = 1;
            this.choice2RadioButton.TabStop = true;
            this.choice2RadioButton.Tag = "2";
            this.choice2RadioButton.Text = "Choice 2";
            this.choice2RadioButton.UseVisualStyleBackColor = true;
            // 
            // choice1RadioButton
            // 
            this.choice1RadioButton.AutoSize = true;
            this.choice1RadioButton.ForeColor = System.Drawing.Color.Blue;
            this.choice1RadioButton.Location = new System.Drawing.Point(23, 105);
            this.choice1RadioButton.Name = "choice1RadioButton";
            this.choice1RadioButton.Size = new System.Drawing.Size(96, 24);
            this.choice1RadioButton.TabIndex = 0;
            this.choice1RadioButton.TabStop = true;
            this.choice1RadioButton.Tag = "1";
            this.choice1RadioButton.Text = "Choice 1";
            this.choice1RadioButton.UseVisualStyleBackColor = true;
            // 
            // checkButton
            // 
            this.checkButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("checkButton.BackgroundImage")));
            this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkButton.Location = new System.Drawing.Point(283, 105);
            this.checkButton.Name = "checkButton";
            this.checkButton.Size = new System.Drawing.Size(50, 50);
            this.checkButton.TabIndex = 7;
            this.checkButton.UseVisualStyleBackColor = true;
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // currentQuestionCountLabel
            // 
            this.currentQuestionCountLabel.AutoSize = true;
            this.currentQuestionCountLabel.ForeColor = System.Drawing.Color.Purple;
            this.currentQuestionCountLabel.Location = new System.Drawing.Point(451, 135);
            this.currentQuestionCountLabel.Name = "currentQuestionCountLabel";
            this.currentQuestionCountLabel.Size = new System.Drawing.Size(18, 20);
            this.currentQuestionCountLabel.TabIndex = 8;
            this.currentQuestionCountLabel.Text = "0";
            // 
            // numberCorrectLabel
            // 
            this.numberCorrectLabel.AutoSize = true;
            this.numberCorrectLabel.Location = new System.Drawing.Point(451, 173);
            this.numberCorrectLabel.Name = "numberCorrectLabel";
            this.numberCorrectLabel.Size = new System.Drawing.Size(18, 20);
            this.numberCorrectLabel.TabIndex = 9;
            this.numberCorrectLabel.Text = "0";
            // 
            // outOfThreeLabel
            // 
            this.outOfThreeLabel.AutoSize = true;
            this.outOfThreeLabel.Location = new System.Drawing.Point(470, 173);
            this.outOfThreeLabel.Name = "outOfThreeLabel";
            this.outOfThreeLabel.Size = new System.Drawing.Size(22, 20);
            this.outOfThreeLabel.TabIndex = 10;
            this.outOfThreeLabel.Text = "/3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(475, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "/ 3";
            // 
            // questionCountLabel
            // 
            this.questionCountLabel.AutoSize = true;
            this.questionCountLabel.ForeColor = System.Drawing.Color.Purple;
            this.questionCountLabel.Location = new System.Drawing.Point(372, 135);
            this.questionCountLabel.Name = "questionCountLabel";
            this.questionCountLabel.Size = new System.Drawing.Size(73, 20);
            this.questionCountLabel.TabIndex = 12;
            this.questionCountLabel.Text = "Question";
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.ForeColor = System.Drawing.Color.Green;
            this.correctLabel.Location = new System.Drawing.Point(372, 173);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(121, 20);
            this.correctLabel.TabIndex = 13;
            this.correctLabel.Text = "Number Correct";
            // 
            // nextButton
            // 
            this.nextButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("nextButton.BackgroundImage")));
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nextButton.Enabled = false;
            this.nextButton.Location = new System.Drawing.Point(283, 161);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(50, 50);
            this.nextButton.TabIndex = 14;
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // numberCorrectOutOf3Label
            // 
            this.numberCorrectOutOf3Label.AutoSize = true;
            this.numberCorrectOutOf3Label.Location = new System.Drawing.Point(519, 173);
            this.numberCorrectOutOf3Label.Name = "numberCorrectOutOf3Label";
            this.numberCorrectOutOf3Label.Size = new System.Drawing.Size(26, 20);
            this.numberCorrectOutOf3Label.TabIndex = 15;
            this.numberCorrectOutOf3Label.Text = "/ 3";
            // 
            // currentCorrectLabel
            // 
            this.currentCorrectLabel.AutoSize = true;
            this.currentCorrectLabel.ForeColor = System.Drawing.Color.Green;
            this.currentCorrectLabel.Location = new System.Drawing.Point(499, 173);
            this.currentCorrectLabel.Name = "currentCorrectLabel";
            this.currentCorrectLabel.Size = new System.Drawing.Size(18, 20);
            this.currentCorrectLabel.TabIndex = 16;
            this.currentCorrectLabel.Text = "0";
            // 
            // answerFeedbackLabel
            // 
            this.answerFeedbackLabel.AutoSize = true;
            this.answerFeedbackLabel.Location = new System.Drawing.Point(14, 245);
            this.answerFeedbackLabel.Name = "answerFeedbackLabel";
            this.answerFeedbackLabel.Size = new System.Drawing.Size(84, 20);
            this.answerFeedbackLabel.TabIndex = 17;
            this.answerFeedbackLabel.Text = "Feedback:";
            // 
            // questionFeedbackLabel
            // 
            this.questionFeedbackLabel.AutoSize = true;
            this.questionFeedbackLabel.Location = new System.Drawing.Point(114, 245);
            this.questionFeedbackLabel.Name = "questionFeedbackLabel";
            this.questionFeedbackLabel.Size = new System.Drawing.Size(0, 20);
            this.questionFeedbackLabel.TabIndex = 19;
            // 
            // feedBackLabel
            // 
            this.feedBackLabel.AutoSize = true;
            this.feedBackLabel.Font = new System.Drawing.Font("Lucida Sans Unicode", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.feedBackLabel.ForeColor = System.Drawing.Color.Gold;
            this.feedBackLabel.Location = new System.Drawing.Point(12, 291);
            this.feedBackLabel.Name = "feedBackLabel";
            this.feedBackLabel.Size = new System.Drawing.Size(0, 27);
            this.feedBackLabel.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Papyrus", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(281, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 44);
            this.label2.TabIndex = 20;
            this.label2.Text = "Trivia Now!";
            // 
            // PlayGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 408);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionFeedbackLabel);
            this.Controls.Add(this.feedBackLabel);
            this.Controls.Add(this.answerFeedbackLabel);
            this.Controls.Add(this.choice4RadioButton);
            this.Controls.Add(this.currentCorrectLabel);
            this.Controls.Add(this.choice3RadioButton);
            this.Controls.Add(this.numberCorrectOutOf3Label);
            this.Controls.Add(this.choice2RadioButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.choice1RadioButton);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.questionCountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.outOfThreeLabel);
            this.Controls.Add(this.numberCorrectLabel);
            this.Controls.Add(this.currentQuestionCountLabel);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.questionTextLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "PlayGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Play!";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PlayGame_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label questionTextLabel;
        private System.Windows.Forms.RadioButton choice4RadioButton;
        private System.Windows.Forms.RadioButton choice3RadioButton;
        private System.Windows.Forms.RadioButton choice2RadioButton;
        private System.Windows.Forms.RadioButton choice1RadioButton;
        private System.Windows.Forms.Button checkButton;
        private System.Windows.Forms.Label currentQuestionCountLabel;
        private System.Windows.Forms.Label numberCorrectLabel;
        private System.Windows.Forms.Label outOfThreeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label questionCountLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Label numberCorrectOutOf3Label;
        private System.Windows.Forms.Label currentCorrectLabel;
        private System.Windows.Forms.Label answerFeedbackLabel;
        private System.Windows.Forms.Label questionFeedbackLabel;
        private System.Windows.Forms.Label feedBackLabel;
        private System.Windows.Forms.Label label2;
    }
}