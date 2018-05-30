using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionB2 : Section
	{

		public SectionB2()
		{
			passenger_LoadingT = new Passenger_LoadingT();

		}

		public string designated_zone{get; set;}
           public string distance{get; set;}
           public string min_width{get; set;}
           public string passenger_surface{get; set;}
           public string tactile_warning_strips{get; set;}
           public string passenger_curbs{get; set;}
           public string covered{get; set;}
           public string lighting{get; set;}
           public string lighting_option{get; set;}
           public string lighting_type{get; set;}
           public string comment{get; set;}
           public string recommendations{get; set;}

		[JsonIgnore]
		public Passenger_LoadingT passenger_LoadingT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(Passenger_LoadingT).GetProperties();
			PropertyInfo[] properties2 = typeof(SectionB2).GetProperties();
			for (int i = 0; i < properties.Length; i++)
			{
				SurveyQuestions.Question q = (Question)properties[i].GetValue(passenger_LoadingT);
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}

	}
}
