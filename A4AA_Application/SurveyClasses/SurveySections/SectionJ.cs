using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyTables;
using Newtonsoft.Json;

namespace A4AA_Application.SurveyClasses.SurveySections
{
    public class SectionJ : Section
    {
        public SectionJ()
        {
            communicationT = new CommunicationT();
        }

        private CommunicationT communicationT;
		public string public_phone { get; set; }
		public string phone_clearance { get; set; }
		public string num_phone { get; set; }
		public string tty { get; set; }
		public string staff_tty { get; set; }
		public string assisted_listening { get; set; }
		public string assisted_listen_type { get; set; }
		public string assisted_listen_receiver { get; set; }
		public string listening_signage { get; set; }
		public string staff_listening { get; set; }
		public string acoustics { get; set; }
		public string acoustics_level { get; set; }
		public string alt_comm_methods { get; set; }
		public string alt_comm_type { get; set; }
		public string staff_ASL { get; set; }
		public string captioning_default { get; set; }
		public string theater_captioning { get; set; }
		public string theater_capt_type { get; set; }
		public string auditory_info_visual { get; set; }
		public string visual_info_auditory { get; set; }
		public string website_text_reader { get; set; }
		public string alt_contact { get; set; }
		public string alt_contact_type { get; set; }
		public string shopping_assist { get; set; }
		public string assist_service { get; set; }
		public string assist_fee { get; set; }
		public string store_scooter { get; set; }
		public string scooter_fee { get; set; }
		public string scooter_location { get; set; }
		public string restaurant_allergies { get; set; }
		public string staff_disable_trained { get; set; }
		public string staff_disable_trained_desc { get; set; }
		public string items_reach { get; set; }
		public string service_alt_manner { get; set; }
		public string senior_discount { get; set; }
		public string senior_age { get; set; }
		public string annual_A4A_review { get; set; }
		public string comment { get; set; }
		public string recommendation { get; set; }

		[JsonIgnore]
		public CommunicationT CommunicationT { get => communicationT; set => communicationT = value; }

		public override void SetAnswers()
		{
			PropertyInfo[] properties = typeof(CommunicationT).GetProperties();//here
			PropertyInfo[] properties2 = typeof(SectionJ).GetProperties();//here
			for (int i = 0; i < properties.Length; i++)
			{
				Question q = (Question)properties[i].GetValue(communicationT);//here
				properties2[i].SetValue(this, q.TheAnswer.getAnswer());
			}
		}
	}
}
