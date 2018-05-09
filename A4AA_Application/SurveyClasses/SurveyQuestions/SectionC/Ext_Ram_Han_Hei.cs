using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Ram_Han_Hei : Question
    {
        public Ext_Ram_Han_Hei()
        {
            TheAnswer = new A_Decimal5_2();
            QuestionText = "Top of the handrail gripping surface above the ramp surface height:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
