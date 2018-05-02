using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionD;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
	public class InteriorT
	{

		private Question int_door_open_clearance = new Int_doo_ope_cle();
		private Question int_opening_measurement = new Int_ope_mea();
		private Question int_door_easy_open = new Int_doo_eas_ope();
		private Question int_door_open_force = new Int_doo_ope_for();
		private Question int_door_use_with_fist = new Int_doo_ope_fis();
		private Question five_second_close = new Fiv_sec_clo();
		private Question hallway_width = new Hal_wid();
		private Question narrowest_width = new Nar_wid();
		private Question wheelchair_turnaround = new Whe_tur();
		private Question hallway_obstacles = new Hal_obs();
		private Question hallway_clear = new Hal_cle();
		private Question lighting = new Lig();
		private Question lighting_type = new Lig_Typ();
		private Question service_counter = new Ser_cou();
		private Question counter_height = new Cou_hei();
		private Question writing_surface_height = new Wri_sur_hei();
		private Question drinking_fountain = new Dri_fou();
		private Question comment = new Comment("Type of obstacles, floor surface");
		private Question recommendations = new Recommendations();

		internal Question Int_door_open_clearance { get => int_door_open_clearance; set => int_door_open_clearance = value; }
		internal Question Int_opening_measurment { get => int_opening_measurement; set => int_opening_measurement = value; }
		internal Question Int_door_easy_open { get => int_door_easy_open; set => int_door_easy_open = value; }
		internal Question Int_door_open_force { get => int_door_open_force; set => int_door_open_force = value; }
		internal Question Int_door_use_with_fist { get => int_door_use_with_fist; set => int_door_use_with_fist = value; }
		internal Question Five_second_close { get => five_second_close; set => five_second_close = value; }
		internal Question Hallway_width { get => hallway_width; set => hallway_width = value; }
		internal Question Narrowest_width { get => narrowest_width; set => narrowest_width = value; }
		internal Question Wheelchair_turnaround { get => wheelchair_turnaround; set => wheelchair_turnaround = value; }
		internal Question Hallway_obstacles { get => hallway_obstacles; set => hallway_obstacles = value; }
		internal Question Hallway_clear { get => hallway_clear; set => hallway_clear = value; }
		internal Question Lighting { get => lighting; set => lighting = value; }
		internal Question Lighting_type { get => lighting_type; set => lighting_type = value; }
		internal Question Service_counter { get => service_counter; set => service_counter = value; }
		internal Question Counter_height { get => counter_height; set => counter_height = value; }
		internal Question Writing_surface_height { get => writing_surface_height; set => writing_surface_height = value; }
		internal Question Drinking_fountain { get => drinking_fountain; set => drinking_fountain = value; }
		internal Question Comment { get => comment; set => comment = value; }
		internal Question Recommendations { get => recommendations; set => recommendations = value; }


		//public string Int_door_open_clearance
		//{
		//	get => int_door_open_clearance;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		int_door_open_clearance = value;
		//	}
		//}
		//public double Int_opening_measurement
		//{
		//	get => int_opening_measurement;
		//	set
		//	{
		//		if (value > LARGEST_VALUE_ACCEPTED)
		//			throw new ArgumentOutOfRangeException();

		//		int_opening_measurement = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
		//	}
		//}
		//public string Int_door_easy_open
		//{
		//	get => int_door_easy_open;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		int_door_easy_open = value;
		//	}
		//}
		//public double Int_door_open_force
		//{
		//	get => int_door_open_force;
		//	set
		//	{
		//		if (value > LARGEST_VALUE_ACCEPTED)
		//			throw new ArgumentOutOfRangeException();

		//		int_door_open_force = Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
		//	}
		//}
		//public string Int_door_use_with_fist
		//{
		//	get => int_door_use_with_fist;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		int_door_use_with_fist = value;
		//	}
		//}
		//public string Five_second_close
		//{
		//	get => five_second_close;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		five_second_close = value;
		//	}
		//}
		//public string Hallway_width
		//{
		//	get => hallway_width;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		hallway_width = value;
		//	}
		//}
		//public decimal Narrowest_width
		//{
		//	get => narrowest_width;
		//	set
		//	{
		//		if (value > (decimal)LARGEST_VALUE_ACCEPTED)
		//			throw new ArgumentOutOfRangeException();

		//		narrowest_width = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
		//	}
		//}
		//public string Wheelchair_turnaround
		//{
		//	get => wheelchair_turnaround;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		wheelchair_turnaround = value;
		//	}
		//}
		//public string Hallway_obstacles
		//{
		//	get => hallway_obstacles;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		hallway_obstacles = value;
		//	}
		//}
		//public string Hallway_clear
		//{
		//	get => hallway_clear;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		hallway_clear = value;
		//	}
		//}
		//public string Lighting
		//{
		//	get => lighting;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		lighting = value;
		//	}
		//}
		//public string Lighting_type
		//{
		//	get => lighting_type;
		//	set
		//	{
		//		if (value.Length > 32)
		//			throw new ArgumentOutOfRangeException();

		//		lighting_type = value;
		//	}
		//}
		//public string Service_counter
		//{
		//	get => service_counter;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		service_counter = value;
		//	}
		//}
		//public decimal Counter_height
		//{
		//	get => counter_height;
		//	set
		//	{
		//		if (value > (decimal)LARGEST_VALUE_ACCEPTED)
		//			throw new ArgumentOutOfRangeException();

		//		counter_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
		//	}
		//}
		//public decimal Writing_surface_height
		//{
		//	get => writing_surface_height;
		//	set
		//	{
		//		if (value > (decimal)LARGEST_VALUE_ACCEPTED)
		//			throw new ArgumentOutOfRangeException();

		//		writing_surface_height = (decimal)Math.Round(value, NUM_DIGITS_AFTER_DECIMAL);
		//	}
		//}
		//public string Drinking_fountain
		//{
		//	get => drinking_fountain;
		//	set
		//	{
		//		if (value.Length > 4)
		//			throw new ArgumentOutOfRangeException();

		//		drinking_fountain = value;
		//	}
		//}
		//public string Comment
		//{
		//	get => comment;
		//	set
		//	{
		//		comment = value;
		//	}
		//}
		//public string Recommendations
		//{
		//	get => recommendations;
		//	set
		//	{
		//		recommendations = value;
		//	}
		//}
	}
}
