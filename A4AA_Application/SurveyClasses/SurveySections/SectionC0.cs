using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionC0 : Section
	{
		public SectionC0()
		{
			Exterior_PathwaysT = new Exterior_PathwaysT();
		}

		public string service_animal { get; set; }
		public string service_animal_location { get; set; }
		public string has_exterior_path { get; set; }
		public string min_width { get; set; }
		public string pathway_surface { get; set; }
		public string pathway_curbs { get; set; }
		public string tactile_warning { get; set; }
		public string slope { get; set; }
		public string lighting { get; set; }
		public string lighting_option { get; set; }
		public string lighting_type { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }

		[JsonIgnore]
		public Exterior_PathwaysT Exterior_PathwaysT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(Exterior_PathwaysT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionC0).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(Exterior_PathwaysT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
