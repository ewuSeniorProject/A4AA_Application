using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Res_Inf_Dry_Fis_Typ : Question
    {
        //private string[] options;

        public Res_Inf_Dry_Fis_Typ()
        {
            TheAnswer = new A_Text(255);
            QuestionText = "Hand dryer or towel dispenser:";
            HasOptions = true;

            options = new string[] 
            {
                "Hand Dryer",
                "Tower Dispenser",
                "N/A"
            };
        }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
