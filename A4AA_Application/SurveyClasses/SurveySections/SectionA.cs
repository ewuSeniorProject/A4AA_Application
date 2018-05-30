using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
	public class SectionA : Section
	{

		public SectionA()
		{
			establishmentT = new EstablishmentT();
			configurationT = new ConfigurationT();
			categoryT = new CategoryT();
			userT = new UserT();
		}

		public string name { get; set; }
		public string website { get; set; }
		public string subtype { get; set; }
		public string date { get; set; }
		public string street { get; set; }
		public string city { get; set; }
		public string state { get; set; }
		public string zip { get; set; }
		public string phone { get; set; }
		public string phone_tty { get; set; }
		public string contact_fname { get; set; }
		public string contact_lname { get; set; }
		public string contact_title { get; set; }
		public string contact_email { get; set; }
		public string user_id { get; set; }
		public string cat_id { get; set; }
		public string config_id { get; set; }
		public string config_comment { get; set; }

		private EstablishmentT establishmentT;
		private ConfigurationT configurationT;
		private CategoryT categoryT;
		private UserT userT;

		[JsonIgnore]
		public EstablishmentT EstablishmentT { get => establishmentT; set => establishmentT = value; }
		[JsonIgnore]
		public ConfigurationT ConfigurationT { get => configurationT; set => configurationT = value; }
		[JsonIgnore]
		public CategoryT CategoryT { get => categoryT; set => categoryT = value; }
		[JsonIgnore]
		public UserT UserT { get => userT; set => userT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(EstablishmentT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionA).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(establishmentT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
