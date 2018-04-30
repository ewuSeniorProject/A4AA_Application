using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Tot_Num_Spa : Question
    {
        public Par_Tot_Num_Spa()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Total number of parking spaces on premises:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
