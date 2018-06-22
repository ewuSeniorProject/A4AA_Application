using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Decimal5_2 : Answer
    {
        private decimal data = 0;

        public override void setAnswer(string s)
        {
			if (s != null && !s.Equals(""))
			{
				if (s.Contains("."))
				{
					string[] temp = s.Split('.');
					if (temp[0].Length > 5 || temp[1].Length > 2)
					{
						throw new ArgumentOutOfRangeException();
					}
				}
				data = Convert.ToDecimal(s);
			}
        }

        public override string getAnswer()
        {
            return data.ToString();
        }

        public override string getErrorMessage()
        {
            return "Invalid data. Up to 5 digits left of the decimal and up to 2 digits right of the decimal allowed.";
        }
    }
}

//NOTE: INCOMPLETE