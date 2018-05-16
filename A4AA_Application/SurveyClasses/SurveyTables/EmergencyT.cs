using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionG;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class EmergencyT
    {
        private Question evac_info = new Eva_inf();
        private Question alt_evac_info = new Alt_evac_info();
        private Question evac_info_format = new Eva_inf_for();
        private Question alarms = new Ala();
        private Question location_no_flash = new Loc_no_fla();
        private Question shelter = new She();
        private Question signs_to_exit = new Sig_to_exi();
        private Question wheelschair_plan = new Whe_pla();
        private Question floor_plan_routes = new Flo_pla_rou();
        private Question fire_alarm_height = new Fir_ala_hei();
        private Question fire_extinguisher_height = new Fir_ext_hei();
        private Question comment = new Comment();
        private Question recommendations = new Recommendations();

		public Question Evac_info { get => evac_info; set => evac_info = value; }
		public Question Alt_evac_info { get => alt_evac_info; set => alt_evac_info = value; }
		public Question Evac_info_format { get => evac_info_format; set => evac_info_format = value; }
		public Question Alarms { get => alarms; set => alarms = value; }
		public Question Location_no_flash { get => location_no_flash; set => location_no_flash = value; }
		public Question Shelter { get => shelter; set => shelter = value; }
		public Question Signs_to_exit { get => signs_to_exit; set => signs_to_exit = value; }
		public Question Wheelschair_plan { get => wheelschair_plan; set => wheelschair_plan = value; }
		public Question Floor_plan_routes { get => floor_plan_routes; set => floor_plan_routes = value; }
		public Question Fire_alarm_height { get => fire_alarm_height; set => fire_alarm_height = value; }
		public Question Fire_extinguisher_height { get => fire_extinguisher_height; set => fire_extinguisher_height = value; }
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendations { get => recommendations; set => recommendations = value; }
	}
}
