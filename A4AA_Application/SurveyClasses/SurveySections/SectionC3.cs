using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionC3 : Section
	{
		public SectionC3()
		{
			Main_EntranceT = new Main_EntranceT();
		}

		public string total_num_public_entrances { get; set; }
		public string main_ent_accessible { get; set; }
		public string alt_ent_accessible { get; set; }
		public string accessable_signage { get; set; }
		public string ground_level { get; set; }
		public string threshold_level { get; set; }
		public string threshold_beveled { get; set; }
		public string beveled_height { get; set; }
		public string door_action { get; set; }
		public string door_open_clearance { get; set; }
		public string opening_measurement { get; set; }
		public string door_easy_open { get; set; }
		public string door_open_force { get; set; }
		public string door_use_with_fist { get; set; }
		public string door_auto_open { get; set; }
		public string second_door_inside { get; set; }
		public string min_dist_between_doors { get; set; }
		public string lighting { get; set; }
		public string lighting_option { get; set; }
		public string lighting_type { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }

		[JsonIgnore]
		public Main_EntranceT Main_EntranceT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(Main_EntranceT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionC3).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(Main_EntranceT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}

	}
}
