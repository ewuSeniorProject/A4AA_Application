using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Est_Nam : Question
    {
        public Est_Nam()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "Establishment Name:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
