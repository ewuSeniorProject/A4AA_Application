using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Decimal5_2 : Answer
    {
        private decimal data;

        public override void setAnswer(string s)
        {
            string[] temp = s.Split('.');
            if (temp[0].Length > 5 || temp[1].Length > 2)
            {
                throw new ArgumentOutOfRangeException();
            }
            data = Convert.ToDecimal(s);
        }

        public override string getAnswer()
        {
            return data.ToString();
        }
    }
}

//NOTE: INCOMPLETE