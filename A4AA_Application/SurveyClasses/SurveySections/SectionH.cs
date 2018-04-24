using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionH
    {
        public SectionH()
        {
            seatingT = new SeatingT();
        }

        private SeatingT seatingT;

        public SeatingT SeatingT { get => seatingT; set => seatingT = value; }
    }
}
