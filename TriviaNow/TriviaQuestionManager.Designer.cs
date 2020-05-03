namespace TriviaNow
{
	partial class TriviaQuestionManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TriviaQuestionManager));
            this.listOfQuestionListBox = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAndCloseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionManagerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionGroupBox = new System.Windows.Forms.GroupBox();
            this.questionLabel = new System.Windows.Forms.Label();
            this.correctChoiceLabel = new System.Windows.Forms.Label();
            this.questionTextBox = new System.Windows.Forms.TextBox();
            this.correctChoiceTextBox = new System.Windows.Forms.TextBox();
            this.questionDetailButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.questionGroupBox.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listOfQuestionListBox
            // 
            this.listOfQuestionListBox.FormattingEnabled = true;
            this.listOfQuestionListBox.ItemHeight = 20;
            this.listOfQuestionListBox.Location = new System.Drawing.Point(6, 25);
            this.listOfQuestionListBox.Name = "listOfQuestionListBox";
            this.listOfQuestionListBox.Size = new System.Drawing.Size(282, 304);
            this.listOfQuestionListBox.TabIndex = 0;
            this.listOfQuestionListBox.Click += new System.EventHandler(this.ActionEventHandler);
            this.listOfQuestionListBox.DoubleClick += new System.EventHandler(this.listOfQuestionListBox_DoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.questionManagerToolStripMenuItem,
            this.gameToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(691, 33);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveAndCloseToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveAndCloseToolStripMenuItem
            // 
            this.saveAndCloseToolStripMenuItem.Name = "saveAndCloseToolStripMenuItem";
            this.saveAndCloseToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.saveAndCloseToolStripMenuItem.Text = "Save and &Close";
            this.saveAndCloseToolStripMenuItem.Click += new System.EventHandler(this.saveAndCloseToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(216, 30);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.ActionEventHandler);
            // 
            // questionManagerToolStripMenuItem
            // 
            this.questionManagerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionToolStripMenuItem,
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.questionManagerToolStripMenuItem.Name = "questionManagerToolStripMenuItem";
            this.questionManagerToolStripMenuItem.Size = new System.Drawing.Size(171, 29);
            this.questionManagerToolStripMenuItem.Text = "Question Manager";
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.addQuestionToolStripMenuItem.Text = "&Add Question";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.editToolStripMenuItem.Text = "&Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(207, 30);
            this.deleteToolStripMenuItem.Text = "&Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playGameToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(70, 29);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // playGameToolStripMenuItem
            // 
            this.playGameToolStripMenuItem.Name = "playGameToolStripMenuItem";
            this.playGameToolStripMenuItem.Size = new System.Drawing.Size(179, 30);
            this.playGameToolStripMenuItem.Text = "&Play Game";
            this.playGameToolStripMenuItem.Click += new System.EventHandler(this.playGameToolStripMenuItem_Click);
            // 
            // questionGroupBox
            // 
            this.questionGroupBox.Controls.Add(this.listOfQuestionListBox);
            this.questionGroupBox.Location = new System.Drawing.Point(12, 107);
            this.questionGroupBox.Name = "questionGroupBox";
            this.questionGroupBox.Size = new System.Drawing.Size(314, 341);
            this.questionGroupBox.TabIndex = 2;
            this.questionGroupBox.TabStop = false;
            this.questionGroupBox.Text = "Questions";
            // 
            // questionLabel
            // 
            this.questionLabel.AutoSize = true;
            this.questionLabel.Location = new System.Drawing.Point(358, 132);
            this.questionLabel.Name = "questionLabel";
            this.questionLabel.Size = new System.Drawing.Size(81, 20);
            this.questionLabel.TabIndex = 3;
            this.questionLabel.Text = "Question: ";
            // 
            // correctChoiceLabel
            // 
            this.correctChoiceLabel.AutoSize = true;
            this.correctChoiceLabel.Location = new System.Drawing.Point(362, 188);
            this.correctChoiceLabel.Name = "correctChoiceLabel";
            this.correctChoiceLabel.Size = new System.Drawing.Size(118, 20);
            this.correctChoiceLabel.TabIndex = 4;
            this.correctChoiceLabel.Text = "Correct Choice:";
            // 
            // questionTextBox
            // 
            this.questionTextBox.Location = new System.Drawing.Point(507, 132);
            this.questionTextBox.Name = "questionTextBox";
            this.questionTextBox.Size = new System.Drawing.Size(172, 26);
            this.questionTextBox.TabIndex = 5;
            // 
            // correctChoiceTextBox
            // 
            this.correctChoiceTextBox.Location = new System.Drawing.Point(507, 188);
            this.correctChoiceTextBox.Name = "correctChoiceTextBox";
            this.correctChoiceTextBox.Size = new System.Drawing.Size(172, 26);
            this.correctChoiceTextBox.TabIndex = 6;
            // 
            // questionDetailButton
            // 
            this.questionDetailButton.Location = new System.Drawing.Point(507, 260);
            this.questionDetailButton.Name = "questionDetailButton";
            this.questionDetailButton.Size = new System.Drawing.Size(172, 31);
            this.questionDetailButton.TabIndex = 7;
            this.questionDetailButton.Text = "Question Details";
            this.questionDetailButton.UseVisualStyleBackColor = true;
            this.questionDetailButton.Click += new System.EventHandler(this.ActionEventHandler);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 542);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(691, 30);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(60, 25);
            this.statusLabel.Text = "Ready";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Location = new System.Drawing.Point(18, 54);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(132, 20);
            this.searchLabel.TabIndex = 9;
            this.searchLabel.Text = "Search Question:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(168, 54);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(226, 26);
            this.searchTextBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(417, 49);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(86, 36);
            this.searchButton.TabIndex = 11;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(533, 50);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(86, 36);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // TriviaQuestionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(691, 572);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.questionDetailButton);
            this.Controls.Add(this.correctChoiceTextBox);
            this.Controls.Add(this.questionTextBox);
            this.Controls.Add(this.correctChoiceLabel);
            this.Controls.Add(this.questionLabel);
            this.Controls.Add(this.questionGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TriviaQuestionManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trivia Now!";
            this.Load += new System.EventHandler(this.TriviaQuestionManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.questionGroupBox.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox listOfQuestionListBox;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.GroupBox questionGroupBox;
		private System.Windows.Forms.Label questionLabel;
		private System.Windows.Forms.Label correctChoiceLabel;
		private System.Windows.Forms.TextBox questionTextBox;
		private System.Windows.Forms.TextBox correctChoiceTextBox;
		private System.Windows.Forms.Button questionDetailButton;
		private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveAndCloseToolStripMenuItem;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.ToolStripMenuItem questionManagerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playGameToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
    }
}

