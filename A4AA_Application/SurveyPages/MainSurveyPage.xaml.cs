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
		private Pages p;
		private Survey theSurvey;

		public MainSurveyPage (Pages pages, Survey theSurvey)
		{
			InitializeComponent();
            Title = "Your Survey!";
			p = pages;
			this.theSurvey = theSurvey;
		}

        async void OnClickedA(object sender, EventArgs args)
        {
            await Navigation.PushAsync(p.A);
        }
        async void OnClickedB(object sender, EventArgs args)
        {
            await Navigation.PushAsync(p.B);
        }
         void OnClickedC(object sender, EventArgs args)
        {
             Navigation.PushAsync(p.C);
        }
        void OnClickedD(object sender, EventArgs args)
        {
			Navigation.PushAsync(p.D);
		}
		async void OnClickedE(object sender, EventArgs args)
        {
			await Navigation.PushAsync(p.E);
		}
		async void OnClickedF(object sender, EventArgs args)
        {
            await Navigation.PushAsync(p.F);
        }
        async void OnClickedG(object sender, EventArgs args)
        {
           await Navigation.PushAsync(p.G);
        }
        async void OnClickedH(object sender, EventArgs args)
        {
            await Navigation.PushAsync(p.H);
        }
        async void OnClickedI(object sender, EventArgs args)
        {
            await Navigation.PushAsync(p.I);
        }
        async void OnClickedJ(object sender, EventArgs args)
        {
            await Navigation.PushAsync(p.J);
        }

		public void Sub_Sur_clicked(object sender, EventArgs args)
		{
			theSurvey.AddTablesToDB();
		}
        /*
        private string[] loadQuestions()
        {
            var assembly = typeof(App).GetTypeInfo().Assembly;
            Stream stream = assembly.GetManifestResourceStream("A4AA_Application.Droid.surveyQuestions.txt");
            string text = "";

            using (var reader = new System.IO.StreamReader(stream))
            {
                text = reader.ReadToEnd();
            }

            return text.Split('\n');
        }

        private void breakApartQuestion(string[] theQuestions)
        {
            foreach (string s in theQuestions)
            {
                string[] temp = s.Split(new string[] { "/:" }, StringSplitOptions.None);
                string category = temp[0];
                string questionNumber = temp[1];
                string theQuestion = temp[2];
                string answerType = temp[3];


            }
        }

		private void Entry_Completed(object sender, EventArgs e)
		{
			String userEntry = ((Entry)sender).Text;
			sendAndResponse(userEntry);
		}

		private async void sendAndResponse(String userEntry)
		{
			using (var httpClient = new HttpClient())
			{
				simpleJsonClass sjc = new simpleJsonClass(userEntry);
				var uri = new Uri("http://mizesolutions.com/a4aa1/a4aa/src/a4aa_rec.php");
				var response = httpClient.PostAsync(uri, new StringContent(sjc.toJsonString(), Encoding.UTF8, "application/json")).Result;
				resLabel.Text = await response.Content.ReadAsStringAsync();
			}
		}*/
    }
	
}