using System;
using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyClasses.SurveyQuestions;
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
			SectionD = theSurvey.SectionD;
			InitializeComponent();
			Title = "Section D";

			var layout = this.FindByName<StackLayout>("theStackLayout");
		}
	}
}