using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionE;

namespace A4AA_Application.SurveyClasses.SurveyTables
{
	public class ElevatorT
	{
		private Question is_elevator = new Is_elevator();
		private Question location = new Location();
		private Question works = new Works();
		private Question no_assist = new No_assist();
		private Question button_height = new Button_height();
		private Question outside_btn_height = new Outside_btn_height();
		private Question inside_btn_height = new Inside_btn_height();
		private Question button_use_fist = new Button_use_fist();
		private Question braille = new Braille();
		private Question audible_tones = new Audible_tones();
		private Question lighting = new Lig();
		private Question lighting_type = new Lig_Typ();
		private Question elevator_depth = new Elevator_depth();
		private Question comment = new Comment(@"about any above items and information such as how quickly the door closes, gaps in the floor, where key is located / accessed, ease of use of lift key, height of emergency telephone in elevator, hazards noted:");
		private Question recommendation = new Recommendations();

		public Question Is_elevator { get => is_elevator; set => is_elevator = value; }
		public Question Location { get => location; set => location = value; }
		public Question Works { get => works; set => works = value; }
		public Question No_assist { get => no_assist; set => no_assist = value; }
		public Question Button_height { get => button_height; set => button_height = value; }
		public Question Outside_btn_height { get => outside_btn_height; set => outside_btn_height = value; }
		public Question Inside_btn_height { get => inside_btn_height; set => inside_btn_height = value; }
		public Question Button_use_fist { get => button_use_fist; set => button_use_fist = value; }
		public Question Braille { get => braille; set => braille = value; }
		public Question Audible_tones { get => audible_tones; set => audible_tones = value; }
		public Question Lighting { get => lighting; set => lighting = value; }
		public Question Lighting_type { get => lighting_type; set => lighting_type = value; }
		public Question Elevator_depth { get => elevator_depth; set => elevator_depth = value; }
		public Question Comment { get => comment; set => comment = value; }
		public Question Recommendation { get => recommendation; set => recommendation = value; }
	}
}

        