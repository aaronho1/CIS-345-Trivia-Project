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
	public delegate void QuestionCreated(object sender, Question q);

    public partial class AddQuestion : Form
    {
        public event QuestionCreated NewQuestionCreated;

        public AddQuestion()
        {
            InitializeComponent();
        }

        public AddQuestion(Question q)
        {
            InitializeComponent();

            //For showing Question Details in separate window
            questionTextBox.Text = q.QuestionText;
            choice1TextBox.Text = q.Choice1;
            choice2TextBox.Text = q.Choice2;
            choice3TextBox.Text = q.Choice3;
            choice4TextBox.Text = q.Choice4;
            feedbackTextBox.Text = q.Feedback;
            correctChoiceTextBox.Text = q.CorrectChoice;

            //lock and hide buttons from view
            addButton.Hide();
            questionTextBox.ReadOnly = true;
            choice1TextBox.ReadOnly = true;
            choice2TextBox.ReadOnly = true;
            choice3TextBox.ReadOnly = true;
            choice4TextBox.ReadOnly = true;
            feedbackTextBox.ReadOnly = true;
            correctChoiceTextBox.ReadOnly = true;

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Test to see if all required textboxes are filled
                if (questionTextBox.Text == "" || correctChoiceTextBox.Text == "" || choice1TextBox.Text == "" || choice2TextBox.Text == "" || choice3TextBox.Text == "" || choice4TextBox.Text == "" || feedbackTextBox.Text == "")
                {
                    MessageBox.Show("Please fill out all entries");
                    return;
                }
                //add error handling for inputing incorect correct answer textbox            
                else if (Convert.ToInt32(correctChoiceTextBox.Text) != 1 && Convert.ToInt32(correctChoiceTextBox.Text) != 2 && Convert.ToInt32(correctChoiceTextBox.Text) != 3 && Convert.ToInt32(correctChoiceTextBox.Text) != 4)
                {
                    MessageBox.Show("Please input a valid correct answer(1-4)");
                    return;
                }
                //test to see if optional textboxes are filled, if they are, make sure it is a valid number
                else
                {
                    Question tmpQuestion = new Question(questionTextBox.Text);
                    tmpQuestion.Choice1 = choice1TextBox.Text;
                    tmpQuestion.Choice2 = choice2TextBox.Text;
                    tmpQuestion.Choice3 = choice3TextBox.Text;
                    tmpQuestion.Choice4 = choice4TextBox.Text;
                    tmpQuestion.Feedback = feedbackTextBox.Text;
                    tmpQuestion.CorrectChoice = correctChoiceTextBox.Text;

                    //raise NewProductCreated Event
                    if (NewQuestionCreated != null)
                    {
                        NewQuestionCreated(this, tmpQuestion);
                    }

                    //Clear everything
                    questionTextBox.Clear();
                    choice1TextBox.Clear();
                    choice2TextBox.Clear();
                    choice3TextBox.Clear();
                    choice4TextBox.Clear();
                    feedbackTextBox.Clear();
                    correctChoiceTextBox.Clear();
                    questionTextBox.Focus();

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Please input a valid correct answer(1-4)");
            }


        }
	}
}
