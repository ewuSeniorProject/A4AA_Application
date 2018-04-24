using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionJ
    {
        public SectionJ()
        {
            communicationT = new CommunicationT();
        }

        private CommunicationT communicationT;

        public CommunicationT CommunicationT { get => communicationT; set => communicationT = value; }
    }
}
