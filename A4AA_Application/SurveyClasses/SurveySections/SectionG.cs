using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionG
    {
        public SectionG()
        {
            emergencyT = new EmergencyT();
        }

        private EmergencyT emergencyT;

        public EmergencyT EmergencyT { get => emergencyT; set => emergencyT = value; }
    }
}
