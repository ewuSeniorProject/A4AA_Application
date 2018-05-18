using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Res_Inf_Fau_Dep : Question
    {
        public Res_Inf_Fau_Dep()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Inches from faucet control to the front edge of the sink counter:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
