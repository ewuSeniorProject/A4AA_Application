using System;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using A4AA_Application.SurveyClasses.SurveyQuestions.SectionD;
using A4AA_Application.SurveyClasses.SurveySections;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionD : ContentPage
	{
		private Survey theSurvey;
		private SectionD SecD;

		public SurveySectionD(Survey theSurvey)
		{

			this.theSurvey = theSurvey;
			SecD = theSurvey.SectionD;
			InitializeComponent();
			Title = "Section D";

			var layout = this.FindByName<StackLayout>("theStackLayoutD");

			//Questions
			var int_doo_ope_cle = new Label { Text = SecD.InteriorT.Int_door_open_clearance.QuestionText, HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)) };
			var int_doo_ope_cle_ans = new Picker { Title = "Select Yes or No" };
			Int_doo_ope_cle temp2 = (Int_doo_ope_cle)SecD.InteriorT.Int_door_open_clearance;
			foreach (string s in temp2.Options)
			{
				int_doo_ope_cle_ans.Items.Add(s);
			}
			int_doo_ope_cle_ans.SelectedIndexChanged += Int_doo_ope_cle_ansSelectedIndexChanged;

			//Adding to the page
			layout.Children.Add(int_doo_ope_cle);
			layout.Children.Add(int_doo_ope_cle_ans);

		}




		//Events
		private void Int_doo_ope_cle_ansSelectedIndexChanged(object sender, EventArgs e)
		{
			try
			{
				SecD.InteriorT.Int_door_open_clearance.TheAnswer.setAnswer(((Picker)sender).SelectedItem.ToString());
			}
			catch (Exception)
			{
				DisplayAlert("Error", "Unforseen error.", "OK");
			}
		}
	}
}