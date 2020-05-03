// Aaron Ho CIS 345 10:30 - 11:45 AM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class UpdateQuestion : Form
    {
        public event QuestionCreated QuestionUpdated;
        Question currentQuestion;

        public UpdateQuestion()
        {
            InitializeComponent();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            Question tmpQuestion = new Question(questionTextBox.Text);

            currentQuestion.Choice1 = choice1TextBox.Text;
            currentQuestion.Choice2 = choice2TextBox.Text;
            currentQuestion.Choice3 = choice3TextBox.Text;
            currentQuestion.Choice4 = choice4TextBox.Text;
            currentQuestion.Feedback = feedbackTextBox.Text;
            currentQuestion.CorrectChoice = correctChoiceTextBox.Text;

            if (QuestionUpdated != null)
                QuestionUpdated(this, tmpQuestion);

            this.Close();

        }

        public void UpdateData(Question question)
        {
            currentQuestion = question;

            questionTextBox.Text = currentQuestion.QuestionText;
            choice1TextBox.Text = currentQuestion.Choice1;
            choice2TextBox.Text = currentQuestion.Choice2;
            choice3TextBox.Text = currentQuestion.Choice3;
            choice4TextBox.Text = currentQuestion.Choice4;
            feedbackTextBox.Text = currentQuestion.Feedback;
            correctChoiceTextBox.Text = currentQuestion.CorrectChoice;
        }

    }
}
