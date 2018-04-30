using System;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionE : ContentPage
	{
		private Survey theSurvey;

		public SurveySectionE(Survey theSurvey)
		{

			this.theSurvey = theSurvey;
			InitializeComponent();
			Title = "Section E";

			var layout = this.FindByName<StackLayout>("theStackLayout");
		}
	}
}