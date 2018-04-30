﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionI
    {
        public SectionI()
        {
            restroomT = new RestroomT();
            restroom_InfoT = new Restroom_InfoT();
        }

        private RestroomT restroomT;
        private Restroom_InfoT restroom_InfoT;

        public RestroomT RestroomT { get => restroomT; set => restroomT = value; }
        public Restroom_InfoT Restroom_InfoT { get => restroom_InfoT; set => restroom_InfoT = value; }
    }
}