using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionB3 : Section
	{
		public SectionB3()
		{
			sta_BusT = new STA_BusT();
			STA_Route_InfoT = new List<SectionB4>();
		}

		public string sta_service_area { get; set; }
		public string distance { get; set; }
		public string min_width { get; set; }
		public string route_surface { get; set; }
		public string tactile_warning_strips { get; set; }
		public string curb_cuts { get; set; }
		public string lighting { get; set; }
		public string lighting_option { get; set; }
		public string lighting_type { get; set; }
		public string shelter_bench { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }
		[JsonIgnore]
		public string sta_bus_rou_num { get; set; }

		private List<SectionB4> sTA_RouteT;
		public List<SectionB4> STA_Route_InfoT { get => sTA_RouteT; set => sTA_RouteT = value; }

		[JsonIgnore]
		public STA_BusT sta_BusT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(STA_BusT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionB3).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(sta_BusT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}

			foreach (SectionB4 s in STA_Route_InfoT)
			{
				s.SetAnswers();
			}
		}
	}
}
