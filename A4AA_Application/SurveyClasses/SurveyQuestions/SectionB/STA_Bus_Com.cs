﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class STA_Bus_Com : Question
    {
        public STA_Bus_Com()
        {
            TheAnswer = new A_Text(5000);
            QuestionText = "Describe the route from the STA Bus Stop to nearest wheelchair accessible entrance. Include obstacles, safety hazards, or additional welcoming features associated with the route. (Note if temporary or permanent.)";
        }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
