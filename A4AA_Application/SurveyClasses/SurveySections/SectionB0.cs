using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionB0 : Section
	{
		public SectionB0()
		{
			ParkingT = new ParkingT();
		}
		public string lot_free { get; set; }
		public string street_metered { get; set; }
		public string parking_type { get; set; }
		public string total_num_spaces { get; set; }
		public string num_reserved_spaces { get; set; }
		public string num_accessable_space { get; set; }
		public string num_van_accessible { get; set; }
		public string reserve_space_sign { get; set; }
		public string reserve_space_obstacles { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }

		[JsonIgnore]
		public ParkingT ParkingT { get; set; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(ParkingT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionB0).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(ParkingT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}

	}


}
