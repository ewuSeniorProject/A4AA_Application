using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Ram_Wid_Bet_Han : Question
    {
        public Ext_Ram_Wid_Bet_Han()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Width between handrails:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
