using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionH : Section//here
    {
        public SectionH()
        {
            seatingT = new SeatingT();
        }

        private SeatingT seatingT;
		public string seating_no_step  { get; set; }
		public string table_aisles  { get; set; }
		public string legroom  { get; set; }
		public string num_legroom  { get; set; }
		public string rearranged  { get; set; }
		public string num_table_rearranged  { get; set; }
		public string num_chair_rearranged  { get; set; }
		public string round_tables  { get; set; }
		public string num_round_tables  { get; set; }
		public string lighting  { get; set; }
		public string lighting_option  { get; set; }
		public string lighting_type  { get; set; }
		public string adjustable_lighting { get; set; }
		public string low_visual_slim { get; set; }
		public string quiet_table { get; set; }
		public string low_sound { get; set; }
		public string designated_space { get; set; }
		public string num_desig_space { get; set; }
		public string companion_space { get; set; }
		public string comment  { get; set; }
		public string recommendation  { get; set; }

		[JsonIgnore]//put this here
        public SeatingT SeatingT { get => seatingT; set => seatingT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(SeatingT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionH).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(seatingT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
