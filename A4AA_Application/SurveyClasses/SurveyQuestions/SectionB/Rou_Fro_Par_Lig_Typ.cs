using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Rou_Fro_Par_Lig_Typ : Question
    {
        private string[] options;

        public Rou_Fro_Par_Lig_Typ()
        {
            TheAnswer = new A_Text(32);
            QuestionText = "Brightness level:";

            options = new string[] 
            {
                "Low",
                "Medium",
                "Bright"
            };
        }

        public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
