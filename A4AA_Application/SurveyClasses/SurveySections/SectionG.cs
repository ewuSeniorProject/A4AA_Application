using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	[Serializable]
	public class SectionG : Section
    {
		
		public string evac_info { get; set; }
		public string alt_evac_info { get; set; }
		public string evac_info_format { get; set; }
		public string alarms { get; set; }
		public string location_no_flash { get; set; }
		public string shelter { get; set; }
		public string signs_to_exit { get; set; }
		public string wheelschair_plan { get; set; }
		public string floor_plan_routes { get; set; }
		public string fire_alarm_height { get; set; }
		public string fire_extinguisher_height { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }

		
		private EmergencyT emergencyT;


		public SectionG()
        {
            emergencyT = new EmergencyT();
        }

		public override void SetAnswers()
		{

			PropertyInfo[] properties = typeof(EmergencyT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionG).GetProperties();//here
			for(int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(emergencyT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
				/*evac_info = emergencyT.Evac_inf.TheAnswer.getAnswer();
			alt_evac_info = emergencyT.Alt_evac_inf.TheAnswer.getAnswer();
			evac_info_format = emergencyT.Evac_info_forma.TheAnswer.getAnswer();
			alarms = emergencyT.Alarm.TheAnswer.getAnswer();
			location_no_flash = emergencyT.Location_no_flas.TheAnswer.getAnswer();
			shelter = emergencyT.Shelte.TheAnswer.getAnswer();
			signs_to_exit = emergencyT.Signs_to_exi.TheAnswer.getAnswer();
			wheelschair_plan = emergencyT.Wheelschair_pla.TheAnswer.getAnswer();
			floor_plan_routes = emergencyT.Floor_plan_route.TheAnswer.getAnswer();
			fire_alarm_height = emergencyT.Fire_alarm_heigh.TheAnswer.getAnswer();
			fire_extinguisher_height = emergencyT.Fire_extinguisher_heigh.TheAnswer.getAnswer();
			comment = emergencyT.Commen.TheAnswer.getAnswer();
			recommendations = emergencyT.Recommendation.TheAnswer.getAnswer();*/

		}

		[JsonIgnore]
		public EmergencyT EmergencyT
		{
			get {
				//emergencyT.setAnswers();
				return emergencyT; }
			
		}
	}
}
