using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionC2 : Section
    {
		public SectionC2()
		{
			Exterior_RampsT = new Exterior_RampsT();
		}

		public string ramp_required{get; set;}
           public string ramp_available{get; set;}
           public string min_width{get; set;}
           public string width_between_handrails{get; set;}
           public string min_slope{get; set;}
           public string slope{get; set;}
           public string level_landing_both{get; set;}
           public string level_landing_location{get; set;}
           public string obstacles{get; set;}
           public string handrails_both_sides{get; set;}
           public string handrail_sides{get; set;}
           public string handrail_regulation_height{get; set;}
           public string handrail_height{get; set;}
           public string side_guards{get; set;}
           public string lighting{get; set;}
           public string lighting_option{get; set;}
           public string lighting_type{get; set;}
           public string comment{get; set;}
           public string recommendations{get; set;}

		[JsonIgnore]
		public Exterior_RampsT Exterior_RampsT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(Exterior_RampsT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionC2).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(Exterior_RampsT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
