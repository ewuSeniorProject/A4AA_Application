using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Text4 : Answer
    {
        private string data;

        public override void setAnswer(string s)
        {
            if (s.Length > 4)
            {
                throw new ArgumentOutOfRangeException();
            }
            data = s;
        }

        public override string getAnswer()
        {
            return data;
        }
    }
}
