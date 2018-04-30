using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionE
    {
        public SectionE()
        {
            elevatorT = new ElevatorT();
        }

        private ElevatorT elevatorT;

        public ElevatorT ElevatorT { get => elevatorT; set => elevatorT = value; }
    }
}
