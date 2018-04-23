﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    class A_Text255 : Answer
    {
        private string data;

        public override void setAnswer(string s)
        {
            if (s.Length > 255)
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
