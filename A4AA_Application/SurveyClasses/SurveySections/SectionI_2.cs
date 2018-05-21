using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionI_2 : Section
    {
		private Restroom_InfoT restroom_InfoT = new Restroom_InfoT();
		public string restroom_desc {get; set;}
		public string easy_open {get; set;}
		public string lbs_force {get; set;}
		public string clearance {get; set;}
		public string opening {get; set;}
		public string opens_out { get; set; }
		public string use_fist {get; set;}
		public string can_turn_around {get; set;}
		public string turn_width {get; set;}
		public string turn_depth {get; set;}
		public string close_chair_inside {get; set;}
		public string grab_bars {get; set;}
		public string seat_height_req {get; set;}
		public string seat_height {get; set;}
		public string flush_auto_fist {get; set;}
		public string ambulatory_accessible {get; set;}
		public string bar_height {get; set;}
		public string coat_hook {get; set;}
		public string hook_height {get; set;}
		public string sink {get; set;}
		public string sink_height {get; set;}
		public string faucet { get; set; }
		public string faucet_depth {get; set;}
		public string faucet_auto_fist {get; set;}
		public string sink_clearance {get; set;}
		public string sink_clearance_height {get; set;}
		public string sink_pipes {get; set;}
		public string soap_dispenser {get; set;}
		public string soap_height {get; set;}
		public string dry_fist {get; set;}
		public string dry_fist_type {get; set;}
		public string dry_controls {get; set;}
		public string dry_control_height {get; set;}
		public string mirror {get; set;}
		public string mirror_height {get; set;}
		public string shelves { get; set; }
		public string shelf_height {get; set;}
		public string trash_receptacles {get; set;}
		public string hygiene_seat_cover {get; set;}
		public string hygience_cover_height {get; set;}
		public string lighting {get; set;}
		public string lighting_type {get; set;}
		public string comment {get; set;}
		public string recommendation {get; set;}
		

		[JsonIgnore]//put this here
		public Restroom_InfoT Restroom_InfoT { get => restroom_InfoT; set => restroom_InfoT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(Restroom_InfoT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionI_2).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(Restroom_InfoT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
