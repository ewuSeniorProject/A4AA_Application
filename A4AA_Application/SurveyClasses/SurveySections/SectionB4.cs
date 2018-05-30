using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionB4 : Section
	{

		public SectionB4()
		{
			sta_RouteT = new STA_RouteT();
		}
		public string route_num { get; set; }
		public string north_bound_stop { get; set; }
		public string south_bound_stop { get; set; }
		public string east_bound_stop { get; set; }
		public string west_bound_stop { get; set; }

		[JsonIgnore]
		public STA_RouteT sta_RouteT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(STA_RouteT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionB4).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(sta_RouteT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
