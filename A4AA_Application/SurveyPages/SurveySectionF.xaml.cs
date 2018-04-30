using System;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionF : ContentPage
	{
		private Survey theSurvey;

		public SurveySectionF(Survey theSurvey)
		{

			this.theSurvey = theSurvey;
			InitializeComponent();
			Title = "Section F";

			var layout = this.FindByName<StackLayout>("theStackLayout");
		}
	}
}