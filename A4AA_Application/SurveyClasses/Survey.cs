﻿using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveySections;

namespace A4AA_Application.SurveyClasses
{
    public class Survey
    {
        public Survey()
        {
            sectionA = new SectionA();
            sectionB = new SectionB();
            sectionC = new SectionC();
            sectionD = new SectionD();
            sectionE = new SectionE();
            sectionF = new SectionF();
            sectionG = new SectionG();
            sectionH = new SectionH();
            sectionI = new SectionI();
            sectionJ = new SectionJ();
        }

        private SectionA sectionA;
        private SectionB sectionB;
        private SectionC sectionC;
        private SectionD sectionD;
        private SectionE sectionE;
        private SectionF sectionF;
        private SectionG sectionG;
        private SectionH sectionH;
        private SectionI sectionI;
        private SectionJ sectionJ;

        public SectionA SectionA { get => sectionA; set => sectionA = value; }
        public SectionB SectionB { get => sectionB; set => sectionB = value; }
        public SectionC SectionC { get => sectionC; set => sectionC = value; }
        public SectionD SectionD { get => sectionD; set => sectionD = value; }
        public SectionE SectionE { get => sectionE; set => sectionE = value; }
        public SectionF SectionF { get => sectionF; set => sectionF = value; }
        public SectionG SectionG { get => sectionG; set => sectionG = value; }
        public SectionH SectionH { get => sectionH; set => sectionH = value; }
        public SectionI SectionI { get => sectionI; set => sectionI = value; }
        public SectionJ SectionJ { get => sectionJ; set => sectionJ = value; }
    }
}

//blake's comment