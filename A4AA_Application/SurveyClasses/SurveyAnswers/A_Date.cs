﻿using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    class A_Date : Answer
    {
        private DateTime data;

        public override void setAnswer(string s)
        {
            
        }

        public override string getAnswer()
        {
            return data.ToString();
        }
    }
}

//NOTE: INCOMPLETE