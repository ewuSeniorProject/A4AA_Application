using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionE : Section
    {
        public SectionE()
        {
            elevatorT = new ElevatorT();
        }

        private ElevatorT elevatorT;
		public string is_elevator { get; set; }
		public string location { get; set; }
		public string works { get; set; }
		public string no_assist { get; set; }
		public string button_height { get; set; }
		public string outside_btn_height { get; set; }
		public string inside_btn_height { get; set; }
		public string button_use_fist { get; set; }
		public string braille { get; set; }
		public string audible_tones { get; set; }
		public string lighting { get; set; }
		public string lighting_type { get; set; }
		public string elevator_depth { get; set; }
		public string comment { get; set; }
		public string recommendation { get; set; }

		[JsonIgnore]
        public ElevatorT ElevatorT { get => elevatorT; set => elevatorT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(ElevatorT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionE).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(elevatorT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
