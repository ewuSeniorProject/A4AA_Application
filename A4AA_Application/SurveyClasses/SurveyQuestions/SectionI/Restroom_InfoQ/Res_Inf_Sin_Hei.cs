using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Res_Inf_Sin_Hei : Question
    {
        public Res_Inf_Sin_Hei()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Inches from height of the sink countertop to the floor:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
