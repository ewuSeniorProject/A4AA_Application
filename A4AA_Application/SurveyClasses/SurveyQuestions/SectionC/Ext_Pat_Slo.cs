using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyAnswers;

namespace A4AA_Application.SurveyClasses.SurveyQuestions
{
    public class Ext_Pat_Slo : YesNoQuestion
    {
        public Ext_Pat_Slo() : base("The running slope of the pathway is no steeper than 1:20, i.e. for every inch of height change there are at least 20 inches of route run. (If steeper than 1:20, note as ramp, and assess handrails in comment section.)") { }
    }
}
