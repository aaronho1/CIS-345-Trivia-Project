// Aaron Ho CIS 345 10:30 - 11:45 AM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriviaNow
{
    public partial class PlayGame : Form
    {
        List<Question> gameQuestionList;
        Random randomGenerator;
        int index;
        Question tmpQuestion;
        int questionCount = 1;
        int correctQuestionCount = 0;
        SoundPlayer soundPlayer;
        string incorrectAnswer = "Incorrect";

        public PlayGame()
        {
            InitializeComponent();
        }

        public PlayGame(List<Question> gameQuestionList)
        {
            InitializeComponent();

            soundPlayer = new SoundPlayer();

            this.gameQuestionList = gameQuestionList;

            randomGenerator = new Random();
            index = randomGenerator.Next(gameQuestionList.Count);
            tmpQuestion = gameQuestionList.ElementAt(index);

            currentQuestionCountLabel.Text = Convert.ToString(questionCount);

            //Populate with information on the first question
            questionTextLabel.Text = tmpQuestion.QuestionText;
            choice1RadioButton.Text = tmpQuestion.Choice1;
            choice2RadioButton.Text = tmpQuestion.Choice2;
            choice3RadioButton.Text = tmpQuestion.Choice3;
            choice4RadioButton.Text = tmpQuestion.Choice4;            
        }

        private void checkButton_Click(object sender, EventArgs e)
        {            
            if (choice1RadioButton.Checked == true)
            {
                if(tmpQuestion.CorrectChoice == (string)choice1RadioButton.Tag)
                {
                    CorrectAnswer(tmpQuestion);
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            else if(choice2RadioButton.Checked == true)
            {
                if(tmpQuestion.CorrectChoice == (string)choice2RadioButton.Tag)
                {
                    CorrectAnswer(tmpQuestion);
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            else if(choice3RadioButton.Checked == true)
            {
                if(tmpQuestion.CorrectChoice == (string)choice3RadioButton.Tag)
                {
                    CorrectAnswer(tmpQuestion);
                }
                else
                {
                    IncorrectAnswer();
                }
            }
            else if(choice4RadioButton.Checked == true)
            {
                if(tmpQuestion.CorrectChoice ==(string)choice4RadioButton.Tag)
                {
                    CorrectAnswer(tmpQuestion);
                }
                else
                {
                    IncorrectAnswer();
                }
            }
                      
            //lock down answers and check button until click next
            choice1RadioButton.Enabled = false;
            choice2RadioButton.Enabled = false;
            choice3RadioButton.Enabled = false;
            choice4RadioButton.Enabled = false;
            checkButton.Enabled = false;
            nextButton.Enabled = true;

            //Remove the asked question from Game list
            gameQuestionList.Remove(tmpQuestion);


            if (questionCount == 3)
            {
                nextButton.Enabled = false;
                feedBackLabel.Text = "Thanks for Playing. You may exit out of this page.";
                soundPlayer = new SoundPlayer("exit.wav");
                soundPlayer.Load();
                soundPlayer.Play();
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            //make answer choices and checkButton available
            choice1RadioButton.Enabled = true;
            choice2RadioButton.Enabled = true;
            choice3RadioButton.Enabled = true;
            choice4RadioButton.Enabled = true;
            checkButton.Enabled = true;

            //Reset Feedback
            questionFeedbackLabel.Text = "";

            //Increment question count
            questionCount++;
            currentQuestionCountLabel.Text = Convert.ToString(questionCount);

            //Generate new random question from game list
            randomGenerator = new Random();
            index = randomGenerator.Next(gameQuestionList.Count);
            tmpQuestion = gameQuestionList.ElementAt(index);

            questionTextLabel.Text = tmpQuestion.QuestionText;
            choice1RadioButton.Text = tmpQuestion.Choice1;
            choice2RadioButton.Text = tmpQuestion.Choice2;
            choice3RadioButton.Text = tmpQuestion.Choice3;
            choice4RadioButton.Text = tmpQuestion.Choice4;

            nextButton.Enabled = false;
        }

        private void CorrectAnswer(Question tmpQuestion)
        {
            //Run Correct Answer actions(sound, feedback, color)
            soundPlayer = new SoundPlayer("ding.wav");
            soundPlayer.Load();
            soundPlayer.Play();

            questionFeedbackLabel.Text = tmpQuestion.Feedback;
            questionFeedbackLabel.ForeColor = System.Drawing.Color.Green;
            correctQuestionCount++;            
            currentCorrectLabel.Text = Convert.ToString(correctQuestionCount);
        }

        private void IncorrectAnswer()
        {
            //Run incorrect actions(sounds, feedback, color)          
            questionFeedbackLabel.Text = incorrectAnswer;
            questionFeedbackLabel.ForeColor = System.Drawing.Color.Red;
            soundPlayer = new SoundPlayer("buzz.wav");
            soundPlayer.Load();
            soundPlayer.Play();
        }

        private void PlayGame_FormClosed(object sender, FormClosedEventArgs e)
        {            
            soundPlayer.Stop();
        }
    }
}
