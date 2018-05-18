using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Res_Inf_Sin_Cle_Hei : Question
    {
        public Res_Inf_Sin_Cle_Hei()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Inches from the floor to allow for a wheelchair to roll under the sink:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
