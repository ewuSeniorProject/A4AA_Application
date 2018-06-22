using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionF : Section
    {
        public SectionF()
        {
            signageT = new SignageT();
        }

        private SignageT signageT;
		public string is_directory { get; set; } 
		public string door_signs { get; set; }
		public string sign_height { get; set; }
		public string pub_sign_braile { get; set; }
		public string sign_high_contrast { get; set; }
		public string sign_images { get; set; }
		public string written_material_images { get; set; }
		public string menu_access { get; set; }
		public string alt_info { get; set; } 
		public string alt_info_type { get; set; }
		public string comment { get; set; }
		public string recommendation { get; set; }

		[JsonIgnore]
        public SignageT SignageT { get => signageT; set => signageT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(SignageT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionF).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(signageT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
