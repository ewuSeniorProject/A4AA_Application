using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Sta_Han_Hei : Question
    {
        public Ext_Sta_Han_Hei()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Top of the handrail gripping surface height:";
            ErrorMessage = "Invalid data. 11 characters allowed.";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
