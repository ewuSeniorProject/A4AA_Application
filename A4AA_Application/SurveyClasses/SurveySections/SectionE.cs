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
		public string is_elevator { get; set; }Is_elevator();
		public string location { get; set; }Location();
		public string works { get; set; }Works();
		public string no_assist { get; set; }No_assist();
		public string button_height { get; set; }Button_height();
		public string outside_btn_height { get; set; }Outside_btn_height();
		public string inside_btn_height { get; set; }Inside_btn_height();
		public string button_use_fist { get; set; }Button_use_fist();
		public string braille { get; set; }Braille();
		public string audible_tones { get; set; }Audible_tones();
		public string lighting { get; set; }Lig();
		public string lighting_type { get; set; }Lig_Typ();
		public string elevator_depth { get; set; }Elevator_depth();
		public string comment { get; set; }Comment(@"about any above items and information such as how quickly the door closes, gaps in the floor, where key is located / accessed, ease of use of lift key, height of emergency telephone in elevator, hazards noted:");
		public string recommendation { get; set; }Recommendations();

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
