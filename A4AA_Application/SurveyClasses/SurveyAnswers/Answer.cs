using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyAnswers
{
    abstract class Answer
    {
        public abstract void setAnswer(string s);
        public abstract string getAnswer();
    }
}
