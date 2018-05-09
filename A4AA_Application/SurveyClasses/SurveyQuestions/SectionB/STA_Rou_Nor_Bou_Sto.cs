using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class STA_Rou_Nor_Bou_Sto : Question
    {
        public STA_Rou_Nor_Bou_Sto()
        {
            TheAnswer = new A_Int11();
            QuestionText = "North Bound Stop:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
