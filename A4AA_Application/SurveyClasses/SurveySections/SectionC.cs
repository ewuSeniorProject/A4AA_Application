using System;
using System.Collections.Generic;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyTables;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    class SectionC
    {
        private Exterior_PathwaysT exterior_PathwaysT;
        private Exterior_RampsT exterior_RampsT;
        private Exterior_StairsT exterior_StairsT;
        private Main_EntranceT main_entranceT;

        public Exterior_PathwaysT Exterior_PathwaysT { get => exterior_PathwaysT; set => exterior_PathwaysT = value; }
        public Exterior_RampsT Exterior_RampsT { get => exterior_RampsT; set => exterior_RampsT = value; }
        public Exterior_StairsT Exterior_StairsT { get => exterior_StairsT; set => exterior_StairsT = value; }
        public Main_EntranceT Main_entranceT { get => main_entranceT; set => main_entranceT = value; }
    }
}
