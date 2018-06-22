using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionF;
using System;
using System.Collections.Generic;
using System.Text;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
	public class SignageT
	{
		private Question is_directory = new Is_dir();
		private Question door_signs = new Doo_sig();
		private Question sign_height = new Sig_hei();
		private Question pub_sign_braile = new Pub_sig_bra();
		private Question sign_high_contrast = new Sig_hig_con();
		private Question sign_images = new Sig_img();
		private Question written_material_images = new Wri_mat();
		private Question menu_access = new Men_acc();
		private Question alt_info = new Alt_inf();
		private Question alt_info_type = new Alt_inf_typ();
		private Question comment = new Comment();
		private Question recommendation = new Recommendations();

		public Question Is_directory { get => is_directory; set => is_directory = value; }
		public Question Door_signs { get => door_signs; set => door_signs = value; }
		public Question Sign_height { get => sign_height; set => sign_height = value; }
		public Question Pub_sign_braile { get => pub_sign_braile; set => pub_sign_braile = value; }
		public Question Sign_high_contrast { get => sign_high_contrast; set => sign_high_contrast = value; }
		public Question Sign_images { get => sign_images; set => sign_images = value; }
		public Question Written_material_images { get => written_material_images; set => written_material_images = value; }
		public Question Menu_access { get => menu_access; set => menu_access = value; }
		public Question Alt_info { get => alt_info; set => alt_info = value; }
		public Question Alt_info_type { get => alt_info_type; set => alt_info_type = value; }
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendation { get => recommendation; set => recommendation = value; }
	}
}
