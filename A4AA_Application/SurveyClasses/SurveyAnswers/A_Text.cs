using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Text : Answer
    {
        private string data;
        private int size;

        public A_Text(int size)
        {
            this.size = size;
        }

		public override void setAnswer(string s)
        {
			if (s != null)
			{
				if (s.Length > size)
				{
					throw new ArgumentOutOfRangeException();
				}
				data = s;
			}
        }

        public override string getAnswer()
        {
            return data;
        }

        public override string getErrorMessage()
        {
            return "Invalid data. " + size + " characters allowed.";
        }
    }
}
