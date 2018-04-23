using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    class A_Text : Answer
    {
        private string data;

        public override void setAnswer(string s)
        {
            data = s;
        }

        public override string getAnswer()
        {
            return data;
        }
    }
}
