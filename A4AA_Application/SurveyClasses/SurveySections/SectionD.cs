using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionD : Section
    {
        public SectionD()
        {
            interiorT = new InteriorT();
        }

        private InteriorT interiorT;
		public string int_door_open_clearance { get; set; }
		public string int_opening_measurement { get; set; }
		public string int_door_easy_open { get; set; }
		public string int_door_open_force { get; set; }
		public string int_door_use_with_fist { get; set; }
		public string five_second_close { get; set; }
		public string hallway_width { get; set; }
		public string narrowest_width { get; set; }
		public string wheelchair_turnaround { get; set; }
		public string hallway_obstacles { get; set; }
		public string hallway_clear { get; set; }
		public string lighting { get; set; }
		public string lighting_type { get; set; }
		public string service_counter { get; set; }
		public string counter_height { get; set; }
		public string writing_surface_height { get; set; }
		public string drinking_fountain { get; set; }
		public string comment { get; set; }
		public string recommendations { get; set; }

		[JsonIgnore]
        public InteriorT InteriorT { get => interiorT; set => interiorT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(InteriorT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionD).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(interiorT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
