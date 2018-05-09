using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Sta_Num_Sta : Question
    {
        public Ext_Sta_Num_Sta()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Total number of stair sets on premises:";
            ErrorMessage = "Invalid data. 11 characters allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
