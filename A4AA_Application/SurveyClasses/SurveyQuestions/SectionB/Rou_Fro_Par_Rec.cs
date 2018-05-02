using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Rou_Fro_Par_Rec : Question
    {
        public Rou_Fro_Par_Rec()
        {
            TheAnswer = new A_Text(5000);
            QuestionText = "Recommendations:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
