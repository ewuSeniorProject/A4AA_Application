﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    public class A_Int11 : Answer
    {
        private int data;

        public override void setAnswer(string s)
        {
            data = Convert.ToInt32(s);
        }

        public override string getAnswer()
        {
            return data.ToString();
        }
    }
}

//NOTE: INCOMPLETE