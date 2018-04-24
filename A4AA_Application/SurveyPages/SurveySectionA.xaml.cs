using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using A4AA_Application.SurveyClasses;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace A4AA_Application.SurveyPages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SurveySectionA : ContentPage
	{
        private Survey theSurvey;

		public SurveySectionA ( Survey theSurvey )
		{
            this.theSurvey = theSurvey;
			InitializeComponent ();

            var layout = this.FindByName<StackLayout>("theStackLayout");

            var est_nam = new Label { Text = theSurvey.SectionA.EstablishmentT.Est_Nam.QuestionText , HorizontalTextAlignment = TextAlignment.Center, FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label))};

            layout.Children.Add(est_nam);
		}
	}
}