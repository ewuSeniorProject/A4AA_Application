using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionI : Section
	{
		public SectionI()
		{
			restroomT = new RestroomT();
			restroom_InfoT = new List<SectionI_2>();
		}

		private RestroomT restroomT;
		private List<SectionI_2> restroom_InfoT;
		public string public_restroom { get; set; }
		public string total_num { get; set; }
		public string designated_number { get; set; }
		public string num_wheelchair_sign { get; set; }
		public string sign_accessable { get; set; }
		public string sign_location { get; set; }
		public string key_needed { get; set; }
		public string comment { get; set; }
		public string recommendation { get; set; }

		[JsonIgnore]
		public RestroomT RestroomT { get => restroomT; set => restroomT = value; }
		
		public List<SectionI_2> Restroom_InfoT { get => restroom_InfoT; set => restroom_InfoT = value; }


		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(RestroomT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionI).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
					Question q = (Question)properties[i].GetValue(restroomT);//here
					properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}

			foreach (SectionI_2 s in Restroom_InfoT)
			{
				s.SetAnswers();//here

			}
		}
	}
}
