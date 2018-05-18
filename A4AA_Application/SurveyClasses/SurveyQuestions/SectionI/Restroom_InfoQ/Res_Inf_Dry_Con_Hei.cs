using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Res_Inf_Dry_Con_Hei : Question
    {
        public Res_Inf_Dry_Con_Hei()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Inches controls for hand dryer or towel dispenser are from the floor";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
