using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Par_Res_Spa_Obs : Question
    {
        private string[] options;

        public Par_Res_Spa_Obs()
        {
            TheAnswer = new A_Text(24);
            QuestionText = "Is reserved parking free of obstacles?:";

            options = new String[]
            {
                "Yes",
                "No"
            };
        }

        public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
