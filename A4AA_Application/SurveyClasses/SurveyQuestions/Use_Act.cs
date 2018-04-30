using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Use_Act : Question
    {
        public Use_Act()
        {
            TheAnswer = new A_Text4();
            QuestionText = "Active:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
