using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Mai_Ent_Tot_Num_Pub_Ent : Question
    {
        public Mai_Ent_Tot_Num_Pub_Ent()
        {
            TheAnswer = new A_Int11();
            QuestionText = "Total number of public entrances into the establishment:";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
