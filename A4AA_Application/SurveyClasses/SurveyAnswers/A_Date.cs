using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Date : Answer
    {
        //private DateTime data;
        private string data;

        public override void setAnswer(string s)
        {
            data = s;
        }

        public override string getAnswer()
        {
            return data/*.ToString()*/;
        }
    }
}

//NOTE: INCOMPLETE