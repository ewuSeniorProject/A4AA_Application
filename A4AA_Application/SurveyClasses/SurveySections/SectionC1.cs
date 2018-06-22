using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionC1 : Section
	{
		public SectionC1()
		{
			Exterior_StairsT = new Exterior_StairsT();
		}
		   public string stairs_required{get; set;}
           public string stairs_available{get; set;}
           public string num_stairs{get; set;}
           public string handrail_both_sides{get; set;}
           public string handrail_side{get; set;}
           public string handrail_regulation_height{get; set;}
           public string handrail_height{get; set;}
           public string obstacles{get; set;}
           public string clearly_marked{get; set;}
           public string lighting{get; set;}
           public string lighting_option{get; set;}
           public string lighting_type{get; set;}
           public string comment{get; set;}
           public string recommendations{get; set;}

		[JsonIgnore]
		public Exterior_StairsT Exterior_StairsT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(Exterior_StairsT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionC1).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(Exterior_StairsT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
