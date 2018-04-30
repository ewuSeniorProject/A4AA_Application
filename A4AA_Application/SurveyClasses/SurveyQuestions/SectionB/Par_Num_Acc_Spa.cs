using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Num_Acc_Spa : Question
    {
        public Par_Num_Acc_Spa()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Total number of accessible spaces with 5' wide loading aisles:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
