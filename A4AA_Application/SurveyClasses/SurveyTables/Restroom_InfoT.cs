using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionI.Restroom_InfoQ;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class Restroom_InfoT
    {
        private Question restroom_desc = new Res_desc();
        private Question easy_open = new Eas_ope();
        private Question lbs_force = new Lbs_for();
        private Question clearance = new Cle();
        private Question opening = new Ope();
        private Question opens_out = new Ope_out();
        private Question use_fist = new Use_fis();
        private Question can_turn_around = new Can_tur_aro();
        private Question turn_width = new Tur_wid();
        private Question turn_depth = new Tur_dep();
        private Question close_chair_inside = new Clo_cha_ins();
        private Question grab_bars = new Gra_bar();
        private Question seat_height_req = new Sea_hei_req();
        private Question seat_height = new Sea_hei();
        private Question flush_auto_fist = new Flu_aut_fis();
        private Question ambulatory_accessible = new Amb_acc();
        private Question bar_height = new Bar_hei();
        private Question coat_hook = new Coa_hoo();
        private Question hook_height = new Hoo_hei();
        /*private Question sink;
        private Question sink_height;
        private Question faucet;
        private Question faucet_depth;
        private Question faucet_auto_fist;
        private Question sink_clearance;
        private Question sink_clearance_height;
        private Question sink_pipes;
        private Question soap_dispenser;
        private Question soap_height;
        private Question dry_first;
        private Question dry_fist_type;
        private Question dry_controls;
        private Question dry_control_height;
        private Question mirror;
        private Question mirror_height;
        private Question shelves;
        private Question shelf_height;
        private Question trash_receptacles;
        private Question hygiene_seat_cover;
        private Question hygience_cover_height;
        private Question lighting;
        private Question lighting_type;*/
        private Question comment = new Comment("Additional notes on accessible bathrooms, or on restrooms with potential to be modified for accessibility:");
		private Question recommendation  = new Recommendations();

		public Question Restroom_desc { get => restroom_desc; set => restroom_desc = value; }
		public Question Easy_open { get => easy_open; set => easy_open = value; }
		public Question Lbs_force { get => lbs_force; set => lbs_force = value; }
		public Question Clearance { get => clearance; set => clearance = value; }
		public Question Opening { get => opening; set => opening = value; }
		public Question Opens_out { get => opens_out; set => opens_out = value; }
		public Question Use_fist { get => use_fist; set => use_fist = value; }
		public Question Can_turn_around { get => can_turn_around; set => can_turn_around = value; }
		public Question Turn_width { get => turn_width; set => turn_width = value; }
		public Question Turn_depth { get => turn_depth; set => turn_depth = value; }
		public Question Close_chair_inside { get => close_chair_inside; set => close_chair_inside = value; }
		public Question Grab_bars { get => grab_bars; set => grab_bars = value; }
		public Question Seat_height_req { get => seat_height_req; set => seat_height_req = value; }
		public Question Seat_height { get => seat_height; set => seat_height = value; }
		public Question Flush_auto_fist { get => flush_auto_fist; set => flush_auto_fist = value; }
		public Question Ambulatory_accessible { get => ambulatory_accessible; set => ambulatory_accessible = value; }
		public Question Bar_height { get => bar_height; set => bar_height = value; }
		public Question Coat_hook { get => coat_hook; set => coat_hook = value; }
		public Question Hook_height { get => hook_height; set => hook_height = value; }
		/*public Question Sink { get => sink; set => sink = value; }
		public Question Sink_height { get => sink_height; set => sink_height = value; }
		public Question Faucet { get => faucet; set => faucet = value; }
		public Question Faucet_depth { get => faucet_depth; set => faucet_depth = value; }
		public Question Faucet_auto_fist { get => faucet_auto_fist; set => faucet_auto_fist = value; }
		public Question Sink_clearance { get => sink_clearance; set => sink_clearance = value; }
		public Question Sink_clearance_height { get => sink_clearance_height; set => sink_clearance_height = value; }
		public Question Sink_pipes { get => sink_pipes; set => sink_pipes = value; }
		public Question Soap_dispenser { get => soap_dispenser; set => soap_dispenser = value; }
		public Question Soap_height { get => soap_height; set => soap_height = value; }
		public Question Dry_first { get => dry_first; set => dry_first = value; }
		public Question Dry_fist_type { get => dry_fist_type; set => dry_fist_type = value; }
		public Question Dry_controls { get => dry_controls; set => dry_controls = value; }
		public Question Dry_control_height { get => dry_control_height; set => dry_control_height = value; }
		public Question Mirror { get => mirror; set => mirror = value; }
		public Question Mirror_height { get => mirror_height; set => mirror_height = value; }
		public Question Shelves { get => shelves; set => shelves = value; }
		public Question Shelf_height { get => shelf_height; set => shelf_height = value; }
		public Question Trash_receptacles { get => trash_receptacles; set => trash_receptacles = value; }
		public Question Hygiene_seat_cover { get => hygiene_seat_cover; set => hygiene_seat_cover = value; }
		public Question Hygience_cover_height { get => hygience_cover_height; set => hygience_cover_height = value; }
		public Question Lighting { get => lighting; set => lighting = value; }
		public Question Lighting_type { get => lighting_type; set => lighting_type = value; }*/
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendation { get => recommendation; set => recommendation = value; }
	}
}
