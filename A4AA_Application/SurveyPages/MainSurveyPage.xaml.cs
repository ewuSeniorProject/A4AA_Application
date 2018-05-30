using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Reflection;
using System.IO;
using A4AA_Application.SurveyClasses;

namespace A4AA_Application.SurveyPages
{
	public partial class MainSurveyPage : ContentPage
	{ 
		private Survey theSurvey;

		public MainSurveyPage(Survey theSurvey)
		{
			InitializeComponent();
            Title = "A4AA Survey";

			this.theSurvey = theSurvey;
		}

        async void OnClickedA(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionA(theSurvey));
        }
        async void OnClickedB(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionB(theSurvey));
        }
        async void OnClickedC(object sender, EventArgs args)
        {
             await Navigation.PushAsync(new SurveySectionC(theSurvey));
        }
        async void OnClickedD(object sender, EventArgs args)
        {
			await Navigation.PushAsync(new SurveySectionD(theSurvey));
		}
		async void OnClickedE(object sender, EventArgs args)
        {
			await Navigation.PushAsync(new SurveySectionE(theSurvey));
		}
		async void OnClickedF(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionF(theSurvey));
        }
        async void OnClickedG(object sender, EventArgs args)
        {
           await Navigation.PushAsync(new SurveySectionG(theSurvey));
        }
        async void OnClickedH(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionH(theSurvey));
        }
        async void OnClickedI(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionI(theSurvey));
        }
        async void OnClickedJ(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionJ(theSurvey));
        }

		public void Sub_Sur_clicked(object sender, EventArgs args)
		{
			Task<HttpResponseMessage> response = theSurvey.AddTablesToDB();
			String responseMess = response.Result.ToString();
			if (responseMess.Contains("200") && responseMess.Contains(@"'OK'")){
				DisplayAlert("Status:","Your Survey has been uploaded successfully", "OK");
			} else
			{
				DisplayAlert("Status:", "There was a problem uploading your survey. Remember that there has to be an internet connection", "OK");
			}
			//DisplayAlert("http response:", responseMess, "OK");
		}
        
    }
	
}