namespace TriviaNow
{
    partial class UpdateQuestion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateQuestion));
            this.updateButton = new System.Windows.Forms.Button();
            this.addQuestionGroupBox = new System.Windows.Forms.GroupBox();
            this.correctChoiceTextBox = new System.Windows.Forms.TextBox();
            this.feedbackTextBox = new System.Windows.Forms.TextBox();
            this.choice4TextBox = new System.Windows.Forms.TextBox();
            this.choice3TextBox = new System.Windows.Forms.TextBox();
            this.choice2TextBox = new System.Windows.Forms.TextBox();
            this.choice1TextBox = new System.Windows.Forms.TextBox();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.correctChoiceLabel = new System.Windows.Forms.Label();
            this.feedbackLabel = new System.Windows.Forms.Label();
            this.choice4Label = new System.Windows.Forms.Label();
            this.choice3Label = new System.Windows.Forms.Label();
            this.choice2Label = new System.Windows.Forms.Label();
            this.choice1Label = new System.Windows.Forms.Label();
            this.questionLabel = new System.Windows.Forms.Label();
            this.addQuestionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(330, 359);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(170, 47);
            this.updateButton.TabIndex = 3;
            this.updateButton.Text = "Update and Close";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // addQuestionGroupBox
            // 
            this.addQuestionGroupBox.Controls.Add(this.correctChoiceTextBox);
            this.addQuestionGroupBox.Controls.Add(this.feedbackTextBox);
            this.addQuestionGroupBox.Controls.Add(this.choice4TextBox);
            this.addQuestionGroupBox.Controls.Add(this.choice3TextBox);
            this.addQuestionGroupBox.Controls.Add(this.choice2TextBox);
            this.addQuestionGroupBox.Controls.Add(this.choice1TextBox);
            this.addQuestionGroupBox.Controls.Add(this.questionTextBox);
            this.addQuestionGroupBox.Controls.Add(this.correctChoiceLabel);
            this.addQuestionGroupBox.Controls.Add(this.feedbackLabel);
            this.addQuestionGroupBox.Controls.Add(this.choice4Label);
            this.addQuestionGroupBox.Controls.Add(this.choice3Label);
            this.addQuestionGroupBox.Controls.Add(this.choice2Label);
            this.addQuestionGroupBox.Controls.Add(this.choice1Label);
            this.addQuestionGroupBox.Controls.Add(this.questionLabel);
            this.addQuestionGroupBox.Location = new System.Drawing.Point(28, 26);
            this.addQuestionGroupBox.Name = "addQuestionGroupBox";
            this.addQuestionGroupBox.Size = new System.Drawing.Size(472, 327);
            this.addQuestionGroupBox.TabIndex = 2;
            this.addQuestionGroupBox.TabStop = false;
            this.addQuestionGroupBox.Text = "Question Details";
            // 
            // correctChoiceTextBox
            // 
            this.correctChoiceTextBox.Location = new System.Drawing.Point(214, 282);
            this.correctChoiceTextBox.Name = "correctChoiceTextBox";
            this.correctChoiceTextBox.Size = new System.Drawing.Size(100, 26);
            this.correctChoiceTextBox.TabIndex = 13;
            // 
            // feedbackTextBox
            // 
            this.feedbackTextBox.Location = new System.Drawing.Point(214, 248);
            this.feedbackTextBox.Name = "feedbackTextBox";
            this.feedbackTextBox.Size = new System.Drawing.Size(252, 26);
            this.feedbackTextBox.TabIndex = 12;
            // 
            // choice4TextBox
            // 
            this.choice4TextBox.Location = new System.Drawing.Point(214, 208);
            this.choice4TextBox.Name = "choice4TextBox";
            this.choice4TextBox.Size = new System.Drawing.Size(252, 26);
            this.choice4TextBox.TabIndex = 11;
            this.choice4TextBox.Tag = "4";
            // 
            // choice3TextBox
            // 
            this.choice3TextBox.Location = new System.Drawing.Point(214, 166);
            this.choice3TextBox.Name = "choice3TextBox";
            this.choice3TextBox.Size = new System.Drawing.Size(252, 26);
            this.choice3TextBox.TabIndex = 10;
            this.choice3TextBox.Tag = "3";
            // 
            // choice2TextBox
            // 
            this.choice2TextBox.Location = new System.Drawing.Point(214, 128);
            this.choice2TextBox.Name = "choice2TextBox";
            this.choice2TextBox.Size = new System.Drawing.Size(252, 26);
            this.choice2TextBox.TabIndex = 9;
            this.choice2TextBox.Tag = "2";
            // 
            // choice1TextBox
            // 
            this.choice1TextBox.Location = new System.Drawing.Point(214, 85);
            this.choice1TextBox.Name = "choice1TextBox";
            this.choice1TextBox.Size = new System.Drawing.Size(252, 26);
            this.choice1TextBox.TabIndex = 8;
            this.choice1TextBox.Tag = "1";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(214, 42);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(252, 26);
            this.questionTextBox.TabIndex = 7;
            // 
            // correctChoiceLabel
            // 
            this.correctChoiceLabel.AutoSize = true;
            this.correctChoiceLabel.Location = new System.Drawing.Point(41, 282);
            this.correctChoiceLabel.Name = "correctChoiceLabel";
            this.correctChoiceLabel.Size = new System.Drawing.Size(114, 20);
            this.correctChoiceLabel.TabIndex = 6;
            this.correctChoiceLabel.Text = "Correct Choice";
            // 
            // feedbackLabel
            // 
            this.feedbackLabel.AutoSize = true;
            this.feedbackLabel.Location = new System.Drawing.Point(41, 248);
            this.feedbackLabel.Name = "feedbackLabel";
            this.feedbackLabel.Size = new System.Drawing.Size(80, 20);
            this.feedbackLabel.TabIndex = 5;
            this.feedbackLabel.Text = "Feedback";
            // 
            // choice4Label
            // 
            this.choice4Label.AutoSize = true;
            this.choice4Label.Location = new System.Drawing.Point(41, 208);
            this.choice4Label.Name = "choice4Label";
            this.choice4Label.Size = new System.Drawing.Size(71, 20);
            this.choice4Label.TabIndex = 4;
            this.choice4Label.Text = "Choice 4";
            // 
            // choice3Label
            // 
            this.choice3Label.AutoSize = true;
            this.choice3Label.Location = new System.Drawing.Point(41, 166);
            this.choice3Label.Name = "choice3Label";
            this.choice3Label.Size = new System.Drawing.Size(71, 20);
            this.choice3Label.TabIndex = 3;
            this.choice3Label.Text = "Choice 3";
            // 
            // choice2Label
            // 
            this.choice2Label.AutoSize = true;
            this.choice2Label.Location = new System.Drawing.Point(41, 128);
            this.choice2Label.Name = "choice2Label";
            this.choice2Label.Size = new System.Drawing.Size(71, 20);
            this.choice2Label.TabIndex = 2;
            this.choice2Label.Text = "Choice 2";
            // 
            // choice1Label
            // 
            this.choice1Label.AutoSize = true;
            this.choice1Label.Location = new System.Drawing.Point(41, 85);
            this.choice1Label.Name = "choice1Label";
            this.choice1Label.Size = new System.Drawing.Size(71, 20);
            this.choice1Label.TabIndex = 1;
            this.choice1Label.Text = "Choice 1";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(41, 42);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(77, 20);
            this.questionLabel.TabIndex = 0;
            this.questionLabel.Text = "Question:";
            // 
            // UpdateQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(568, 407);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.addQuestionGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UpdateQuestion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Question";
            this.addQuestionGroupBox.ResumeLayout(false);
            this.addQuestionGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.GroupBox addQuestionGroupBox;
        private System.Windows.Forms.TextBox correctChoiceTextBox;
        private System.Windows.Forms.TextBox feedbackTextBox;
        private System.Windows.Forms.TextBox choice4TextBox;
        private System.Windows.Forms.TextBox choice3TextBox;
        private System.Windows.Forms.TextBox choice2TextBox;
        private System.Windows.Forms.TextBox choice1TextBox;
        private System.Windows.Forms.TextBox questionTextBox;
        private System.Windows.Forms.Label correctChoiceLabel;
        private System.Windows.Forms.Label feedbackLabel;
        private System.Windows.Forms.Label choice4Label;
        private System.Windows.Forms.Label choice3Label;
        private System.Windows.Forms.Label choice2Label;
        private System.Windows.Forms.Label choice1Label;
        private System.Windows.Forms.Label questionLabel;
    }
}