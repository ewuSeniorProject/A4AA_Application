using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionD
    {
        public SectionD()
        {
            interiorT = new InteriorT();
        }

        private InteriorT interiorT;

        public InteriorT InteriorT { get => interiorT; set => interiorT = value; }
    }
}
