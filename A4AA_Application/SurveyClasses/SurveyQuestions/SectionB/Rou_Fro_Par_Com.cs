using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Rou_Fro_Par_Com : Question
    {
        public Rou_Fro_Par_Com()
        {
            TheAnswer = new A_Text(5000);
            QuestionText = "Describe the route from the nearest reserved accessible parking to the nearest accessible entrance. Include obstacles, safety hazards, or additional welcoming features associated with the route. (Note if temporary or permanent.) Does route include going behind other parked vehicles, for instance?";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
