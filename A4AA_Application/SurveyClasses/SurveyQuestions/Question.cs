using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Question
    {
        private Answer theAnswer;
        private string questionText;

        public Answer TheAnswer { get => theAnswer; set => theAnswer = value; }
        public string QuestionText { get => questionText; set => questionText = value; }
    }
}
