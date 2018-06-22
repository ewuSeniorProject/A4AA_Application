using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Mai_Ent_Ope_Mea : Question
    {
        public Mai_Ent_Ope_Mea()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Opening Measurement:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
