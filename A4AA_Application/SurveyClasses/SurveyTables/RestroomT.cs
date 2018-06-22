using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionI;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
    public class RestroomT
    {
        private Question public_restroom = new Pub_res();
        private Question total_num = new Tot_num();
        private Question designated_number = new Des_num();
        private Question num_wheelchair_sign = new Num_whe_sig();
        private Question sign_accessable = new Sig_acc();
        private Question sign_location = new Sig_loc();
        private Question key_needed = new Key_nee();
        private Question comment = new Comment("DESCRIBE the Restroom(s)​ Include where they are located, obstacles, safety hazards, or additional welcoming features such as baby changing tables, step stools,​ etc.Please note how may restrooms were reviewed.");
        private Question recommendation = new Recommendations();

		public Question Public_restroom { get => public_restroom; set => public_restroom = value; }
		public Question Total_num { get => total_num; set => total_num = value; }
		public Question Designated_number { get => designated_number; set => designated_number = value; }
		public Question Num_wheelchair_sign { get => num_wheelchair_sign; set => num_wheelchair_sign = value; }
		public Question Sign_accessable { get => sign_accessable; set => sign_accessable = value; }
		public Question Sign_location { get => sign_location; set => sign_location = value; }
		public Question Key_needed { get => key_needed; set => key_needed = value; }
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendation { get => recommendation; set => recommendation = value; }
	}
}
