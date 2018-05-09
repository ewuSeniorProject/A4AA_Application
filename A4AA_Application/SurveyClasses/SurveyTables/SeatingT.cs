using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionH;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
	public class SeatingT
	{
		private Question seating_no_step = new Sea_no_ste();
		private Question table_aisles = new Tab_ais();
		private Question legroom = new Leg();
		private Question num_legroom = new Num_Leg();
		private Question rearranged = new Rearanged();
		private Question num_table_rearranged = new Num_tab_rea();
		private Question num_chair_rearranged = new Num_cha_rea();
		private Question round_tables = new Rou_Tab();
		private Question num_round_tables = new Num_rou_tab();
		private Question lighting = new Lig();
		private Question lighting_option = new Lig_Opt();
		private Question lighting_type = new Lig_Typ();
		private Question adjustable_lighting = new Adj_lig();
		private Question low_visual_slim = new Low_vis_sli();
		private Question quiet_table = new Qui_tab();
		private Question low_sound = new Low_sou();
		private Question designated_space = new Des_spa();
		private Question num_desig_space = new Num_des_spa();
		private Question companion_space = new Com_spa();
		private Question comment = new Comment("e.g. location of accessible seating in relation to accessible entrance, special features available");
		private Question recommendation = new Recommendations();

		public Question Seating_no_step { get => seating_no_step; set => seating_no_step = value; }
		public Question Table_aisles { get => table_aisles; set => table_aisles = value; }
		public Question Legroom { get => legroom; set => legroom = value; }
		public Question Num_legroom { get => num_legroom; set => num_legroom = value; }
		public Question Rearranged { get => rearranged; set => rearranged = value; }
		public Question Num_table_rearranged { get => num_table_rearranged; set => num_table_rearranged = value; }
		public Question Num_chair_rearranged { get => num_chair_rearranged; set => num_chair_rearranged = value; }
		public Question Round_tables { get => round_tables; set => round_tables = value; }
		public Question Num_round_tables { get => num_round_tables; set => num_round_tables = value; }
		public Question Lighting { get => lighting; set => lighting = value; }
		public Question Lighting_option { get => lighting_option; set => lighting_option = value; }
		public Question Lighting_type { get => lighting_type; set => lighting_type = value; }
		public Question Adjustable_lighting { get => adjustable_lighting; set => adjustable_lighting = value; }
		public Question Low_visual_slim { get => low_visual_slim; set => low_visual_slim = value; }
		public Question Quiet_table { get => quiet_table; set => quiet_table = value; }
		public Question Low_sound { get => low_sound; set => low_sound = value; }
		public Question Designated_space { get => designated_space; set => designated_space = value; }
		public Question Num_desig_space { get => num_desig_space; set => num_desig_space = value; }
		public Question Companion_space { get => companion_space; set => companion_space = value; }
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendation { get => recommendation; set => recommendation = value; }
	}
}