using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Com : Question
    {
        public Par_Com()
        {
            TheAnswer = new A_Text(5000);
            QuestionText = "Describe the parking area and note any obstacles, safety hazards, or additional welcoming features associated with parking. (Note if temporary or permanant.):";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
