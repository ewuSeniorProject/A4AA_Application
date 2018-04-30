using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Num_Van_Acc : Question
    {
        public Par_Num_Van_Acc()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Total number of van-accessible parking spaces (8' wide + 8' wide loading aisles):";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
