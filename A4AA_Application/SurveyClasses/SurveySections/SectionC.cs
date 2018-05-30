using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionC : Section
    {
        public SectionC()
        {
			sectionC0 = new SectionC0();
			sectionC1 = new SectionC1();
			sectionC2 = new SectionC2();
			sectionC3 = new SectionC3();
            exterior_PathwaysT = sectionC0.Exterior_PathwaysT;
            exterior_RampsT = sectionC2.Exterior_RampsT;
            exterior_StairsT = sectionC1.Exterior_StairsT;
            main_entranceT = sectionC3.Main_EntranceT;
        }

        private Exterior_PathwaysT exterior_PathwaysT;
        private Exterior_RampsT exterior_RampsT;
        private Exterior_StairsT exterior_StairsT;
        private Main_EntranceT main_entranceT;

		public SectionC0 sectionC0 { get; }
		public SectionC1 sectionC1 { get; }
		public SectionC2 sectionC2 { get; }
		public SectionC3 sectionC3 { get; }

		[JsonIgnore]
		public Exterior_PathwaysT Exterior_PathwaysT { get => exterior_PathwaysT; set => exterior_PathwaysT = value; }
		[JsonIgnore]
		public Exterior_RampsT Exterior_RampsT { get => exterior_RampsT; set => exterior_RampsT = value; }
		[JsonIgnore]
		public Exterior_StairsT Exterior_StairsT { get => exterior_StairsT; set => exterior_StairsT = value; }
		[JsonIgnore]
		public Main_EntranceT Main_entranceT { get => main_entranceT; set => main_entranceT = value; }

		public override void SetAnswers()
		{
			sectionC0.SetAnswers();
			sectionC1.SetAnswers();
			sectionC2.SetAnswers();
			sectionC3.SetAnswers();
		}
    }
}
