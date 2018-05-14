using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Mai_Ent_Doo_Ope_For : Question
    {
        public Mai_Ent_Doo_Ope_For()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Actual lbs. of force needed:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
