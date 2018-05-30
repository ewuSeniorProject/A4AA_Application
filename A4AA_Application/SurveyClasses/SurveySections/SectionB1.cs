using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionB1 : Section
	{

		public SectionB1()
		{
			route_From_ParkingT = new Route_From_ParkingT();
		}
		public string distance { get; set; }
		public string min_width { get; set; }
		public string route_surface { get; set; }
		public string route_curbs { get; set; }
		public string tactile_warning { get; set; }
		public string covered { get; set; }
		public string lighting { get; set; }
		public string lighting_option { get; set; }
		public string lighting_type { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }

		[JsonIgnore]
		public Route_From_ParkingT route_From_ParkingT { get; set; }

	

	public override void SetAnswers()
	{
		PropertyInfo[] properties = typeof(Route_From_ParkingT).GetProperties();//here
		PropertyInfo[] properties2 = typeof(SectionB1).GetProperties();//here
		for (int i = 0; i < properties.Length; i++)
		{
			SurveyQuestions.Question q = (Question)properties[i].GetValue(route_From_ParkingT);//here
			properties2[i].SetValue(this, q.TheAnswer.getAnswer());
		}
	}
}


		
}

	

