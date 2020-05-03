// Aaron Ho CIS 345 10:30 - 11:45 AM
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriviaNow
{
    [Serializable]
	public class Question
	{
        //Question Details
		string questionText;
		string choice1;
		string choice2;
		string choice3;
		string choice4;
		string correctChoice;
		string feedback;

		public Question()
		{
			this.questionText = "";
		}

		public Question(string questionText)
		{
			this.questionText = questionText;
		}

		public string QuestionText { get => questionText; set => questionText = value; }
		public string Choice1 { get => choice1; set => choice1 = value; }
		public string Choice2 { get => choice2; set => choice2 = value; }
		public string Choice3 { get => choice3; set => choice3 = value; }
		public string Choice4 { get => choice4; set => choice4 = value; }
		public string Feedback { get => feedback; set => feedback = value; }
		public string CorrectChoice { get => correctChoice; set => correctChoice = value; }

		public override string ToString()
		{
			return questionText;
		}
	}
}
