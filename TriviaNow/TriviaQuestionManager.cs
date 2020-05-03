// Aaron Ho CIS 345 10:30 - 11:45 AM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace TriviaNow
{
    [Serializable]
    public partial class TriviaQuestionManager : Form
    {
        AddQuestion addQuestion;
        AddQuestion questionDetails;

        BindingList<Question> questionList;

        Question selectedQuestion;

        UpdateQuestion updateForm;

        PlayGame playGameForm;

        List<Question> searchList;

        public TriviaQuestionManager()
        {
            InitializeComponent();
            questionDetailButton.Visible = false;
        }

        public void ActionEventHandler(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Question tmpQuestion = (Question)listOfQuestionListBox.SelectedItem;

                //show question details
                questionDetails = new AddQuestion(tmpQuestion);
                questionDetails.Text = "Question Details";
                questionDetails.Show();
            }    
            else if (sender is ToolStripMenuItem)
            {
                System.Environment.Exit(0);
            }
            else if (sender is ListBox)
            {
                try
                {
                    //downcast selected item into tmpQuestion 
                    Question tmpQuestion = (Question)listOfQuestionListBox.SelectedItem;

                    questionTextBox.Text = tmpQuestion.QuestionText;
                    correctChoiceTextBox.Text = tmpQuestion.CorrectChoice;
                }
                catch (NullReferenceException)
                {
                    MessageBox.Show("Please input a valid item");
                }
            }
        }

        private void AddQuestion_NewQuestionCreated(object sender, Question q)
        {                        
            questionList.Add(q);
            questionDetailButton.Visible = true;
        }

        private void UpdateForm_QuestionUpdated(object sender, Question q)
        {
            questionList.ResetBindings();
        }

        private void SetEventHandlers()
        {
            //wire event handlers
            addQuestion.NewQuestionCreated += new QuestionCreated(AddQuestion_NewQuestionCreated);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Set FileName and Filter for openFileDialog 
                openFileDialog.FileName = "";
                openFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

                //Set DialogResult
                DialogResult dialogResult = openFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = openFileDialog.FileName;
                    FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                    BinaryFormatter bf = new BinaryFormatter();                    
                    questionList = (BindingList<Question>)bf.Deserialize(file);
                    listOfQuestionListBox.DataSource = questionList;
                    file.Close();
                    statusLabel.Text = "File Loaded";
                    questionDetailButton.Visible = true;
                }
            }
            catch (Exception)
            {
                statusLabel.Text = "File Load Not Successful";
            }
        }

        private void saveAndCloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog.FileName = "";
                saveFileDialog.Filter = "App Data Files (*.dat)|*.dat|All Files (*.*)|*.*";

                DialogResult dialogResult = saveFileDialog.ShowDialog();

                if (dialogResult == DialogResult.OK)
                {
                    string fileName = saveFileDialog.FileName;

                    FileStream file = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                    BinaryFormatter bf = new BinaryFormatter();
                    bf.Serialize(file, questionList);
                    file.Close();
                    System.Environment.Exit(0);
                }
            }
            catch (Exception)
            {
                statusLabel.Text = "File Save Not Successful";
            }
        }        

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listOfQuestionListBox.SelectedItem == null)
                return;

            // get the student which is currently selected
            selectedQuestion = (Question)listOfQuestionListBox.SelectedItem;

            // create the form
            updateForm = new UpdateQuestion();

            // register the event handler
            updateForm.QuestionUpdated += new QuestionCreated(this.UpdateForm_QuestionUpdated);

            // show the form and set it to show details of the selected student
            updateForm.UpdateData(selectedQuestion);
            updateForm.Show();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question tmpQuestion;
            if(listOfQuestionListBox.SelectedItem != null)
            {
                tmpQuestion = (Question) listOfQuestionListBox.SelectedItem;
                questionList.Remove(tmpQuestion);
            }
        }

        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //generate new instance of AddQuestion
            //store object into listbox afterward
            addQuestion = new AddQuestion();
            addQuestion.Text = "Add New Question";
            addQuestion.Show();
            SetEventHandlers();
        }

        private void TriviaQuestionManager_Load(object sender, EventArgs e)
        {            
            //instantiate list
            questionList = new BindingList<Question>();

            //set data source of ListBox
            listOfQuestionListBox.DataSource = questionList;
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Random randomGenerator;
                int index;
                Question tmpQuestion;
                int gameListCount = 0;
                bool duplicate;
                List<Question> gameList = new List<Question>();

                //check to see if there are at least 3 questions
                if (questionList.Count < 3)
                {
                    MessageBox.Show("You need more Questions!");
                }
                else
                {
                    //conditions to add random Question to gameList
                    //will not add if same question is already in list
                    //add 3 questions
                    while (gameListCount <= 2)
                    {
                        //generate a random question to add to gameList
                        randomGenerator = new Random();
                        index = randomGenerator.Next(questionList.Count);
                        tmpQuestion = questionList.ElementAt(index);

                        //test for duplicates
                        duplicate = gameList.Contains(tmpQuestion);

                        if (duplicate == false)
                        {
                            gameList.Add(tmpQuestion);
                            gameListCount += 1;
                        }
                    }
                    playGameForm = new PlayGame(gameList);
                    playGameForm.Show();
                }                
            }
            catch(Exception)
            {
                MessageBox.Show("Your Game List is Empty!");
            }
        }

        private void listOfQuestionListBox_DoubleClick(object sender, EventArgs e)
        {
            if (listOfQuestionListBox.SelectedItem == null)
                return;

            // get the student which is currently selected
            selectedQuestion = (Question)listOfQuestionListBox.SelectedItem;

            // create the form
            updateForm = new UpdateQuestion();

            // register the event handler
            updateForm.QuestionUpdated += new QuestionCreated(this.UpdateForm_QuestionUpdated);

            // show the form and set it to show details of the selected student
            updateForm.UpdateData(selectedQuestion);
            updateForm.Show();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            //Make new temp list for search
            searchList = new List<Question>();

            //add questions to search list
            foreach (Question q in questionList)
            {
                if (q.QuestionText.ToUpper().Contains(searchTextBox.Text.ToUpper()) == true || q.Choice1.ToUpper().Contains(searchTextBox.Text.ToUpper()) == true || q.Choice2.ToUpper().Contains(searchTextBox.Text.ToUpper()) == true || q.Choice3.ToUpper().Contains(searchTextBox.Text.ToUpper()) == true || q.Choice4.ToUpper().Contains(searchTextBox.Text.ToUpper()) == true || q.Feedback.ToUpper().Contains(searchTextBox.Text.ToUpper()) == true) 
                {
                    searchList.Add(q);
                }
            }
            listOfQuestionListBox.DataSource = searchList;
            clearButton.Enabled = true;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            searchList.Clear();
            searchTextBox.Clear();

            //reset data source of ListBox
            listOfQuestionListBox.DataSource = questionList;
        }
    }
} 