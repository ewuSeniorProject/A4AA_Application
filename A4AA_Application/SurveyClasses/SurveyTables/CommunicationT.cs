using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionJ;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class CommunicationT
    {
        private Question public_phone = new Pub_pho();
        private Question phone_clearance = new Pho_cle();
        private Question num_phone = new Num_pho();
        private Question tty = new Tty();
        private Question staff_tty = new Sta_tty();
        private Question assisted_listening = new Ass_lis();
        private Question assisted_listen_type = new Ass_lis_typ();
        private Question assisted_listen_receiver = new Ass_lis_rec();
        private Question listening_signage = new Lis_sig();
		private Question staff_listening = new Sta_lis();
		private Question acoustics = new Aco();
        private Question acoustics_level = new Aco_lev();
        private Question alt_comm_methods = new Alt_com_met();
        private Question alt_comm_type = new Alt_com_typ();
        private Question staff_ASL = new Sta_ASL();
        private Question captioning_default = new Cap_def();
        private Question theater_captioning = new The_cap();
        private Question theater_capt_type = new The_cap_typ();
        private Question auditory_info_visual = new Aud_inf_vis();
        private Question visual_info_auditory = new Vis_inf_aud();
        private Question website_text_reader  = new Web_txt_rea();
        private Question alt_contact = new Alt_con();
        private Question alt_contact_type = new Alt_con_type();
        private Question shopping_assist = new Sho_ass();
        private Question assist_service = new Ass_ser();
        private Question assist_fee = new Fee();
        private Question store_scooter = new Sto_sco();
        private Question scooter_fee = new Fee();
        private Question scooter_location = new Sco_loc();
        private Question restaurant_allergies = new Res_all();
        private Question staff_disable_trained = new Sta_dis_tra();
        private Question staff_disable_trained_desc = new Sta_dis_tra();
        private Question items_reach = new Ite_rea();
        private Question service_alt_manner = new Ser_alt_man();
        private Question senior_discount = new Sen_dis();
        private Question senior_age = new Sen_age();
        private Question annual_A4A_review = new Ann_A4A_rev();
        private Question comment = new Comment("Reasons for “no” answers, additional information");
		private Question recommendation = new Recommendations();

		public Question Public_phone { get => public_phone; set => public_phone = value; }
		public Question Phone_clearance { get => phone_clearance; set => phone_clearance = value; }
		public Question Num_phone { get => num_phone; set => num_phone = value; }
		public Question Tty { get => tty; set => tty = value; }
		public Question Staff_tty { get => staff_tty; set => staff_tty = value; }
		public Question Assisted_listening { get => assisted_listening; set => assisted_listening = value; }
		public Question Assisted_listen_type { get => assisted_listen_type; set => assisted_listen_type = value; }
		public Question Assisted_listen_receiver { get => assisted_listen_receiver; set => assisted_listen_receiver = value; }
		public Question Listening_signage { get => listening_signage; set => listening_signage = value; }
		public Question Staff_listening { get => staff_listening; set => staff_listening = value; }
		public Question Acoustics { get => acoustics; set => acoustics = value; }
		public Question Acoustics_level { get => acoustics_level; set => acoustics_level = value; }
		public Question Alt_comm_methods { get => alt_comm_methods; set => alt_comm_methods = value; }
		public Question Alt_comm_type { get => alt_comm_type; set => alt_comm_type = value; }
		public Question Staff_ASL { get => staff_ASL; set => staff_ASL = value; }
		public Question Captioning_default { get => captioning_default; set => captioning_default = value; }
		public Question Theater_captioning { get => theater_captioning; set => theater_captioning = value; }
		public Question Theater_capt_type { get => theater_capt_type; set => theater_capt_type = value; }
		public Question Auditory_info_visual { get => auditory_info_visual; set => auditory_info_visual = value; }
		public Question Visual_info_auditory { get => visual_info_auditory; set => visual_info_auditory = value; }
		public Question Website_text_reader { get => website_text_reader; set => website_text_reader = value; }
		public Question Alt_contact { get => alt_contact; set => alt_contact = value; }
		public Question Alt_contact_type { get => alt_contact_type; set => alt_contact_type = value; }
		public Question Shopping_assist { get => shopping_assist; set => shopping_assist = value; }
		public Question Assist_service { get => assist_service; set => assist_service = value; }
		public Question Assist_fee { get => assist_fee; set => assist_fee = value; }
		public Question Store_scooter { get => store_scooter; set => store_scooter = value; }
		public Question Scooter_fee { get => scooter_fee; set => scooter_fee = value; }
		public Question Scooter_location { get => scooter_location; set => scooter_location = value; }
		public Question Restaurant_allergies { get => restaurant_allergies; set => restaurant_allergies = value; }
		public Question Staff_disable_trained { get => staff_disable_trained; set => staff_disable_trained = value; }
		public Question Staff_disable_trained_desc { get => staff_disable_trained_desc; set => staff_disable_trained_desc = value; }
		public Question Items_reach { get => items_reach; set => items_reach = value; }
		public Question Service_alt_manner { get => service_alt_manner; set => service_alt_manner = value; }
		public Question Senior_discount { get => senior_discount; set => senior_discount = value; }
		public Question Senior_age { get => senior_age; set => senior_age = value; }
		public Question Annual_A4A_review { get => annual_A4A_review; set => annual_A4A_review = value; }
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendation { get => recommendation; set => recommendation = value; }
	}
}