using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Sta_Obs : YesNoQuestion
    {
        //private string[] options;

        public Ext_Sta_Obs () : base("Stairs are clear of obstacles or protrusions of 4 inches or more from sides, and have firm slip-resistant surfaces.") { }

        //public string[] Options { get => options; set => options = value; }
        //NEED SOME OBJECT OR LOGIC HERE WHICH WILL PROVIDE USER WITH DROP DOWN OF CORRECT POTENTIAL OPTIONS
    }
}
