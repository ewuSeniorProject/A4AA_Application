﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionF
    {
        public SectionF()
        {
            signageT = new SignageT();
        }

        private SignageT signageT;

        public SignageT SignageT { get => signageT; set => signageT = value; }
    }
}
