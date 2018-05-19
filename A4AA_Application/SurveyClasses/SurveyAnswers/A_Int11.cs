using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Int11 : Answer
    {
        private int data = 0;

        public override void setAnswer(string s)
        {
            data = Convert.ToInt32(s);
        }

        public override string getAnswer()
        {
            return data.ToString();
        }

        public override string getErrorMessage()
        {
            return "Invalid data. 11 digits allowed.";
        }
    }
}

//NOTE: INCOMPLETE