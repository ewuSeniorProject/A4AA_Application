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

		public MainSurveyPage ()
		{
			InitializeComponent();
            Title = "Your Survey!";
            theSurvey = new Survey();
			/*var layout = new StackLayout { Padding = new Thickness(5.0, 10.0) };

            string[] separatedLines = loadQuestions();
            Survey theSurvey = new Survey();

			foreach (string s in separatedLines)
			{
				//System.Diagnostics.Debug.WriteLine(s);
				var label = new Label { FontSize = 20 };
				var fs = new FormattedString();
				fs.Spans.Add(new Span { Text = s });
				label.FormattedText = fs;
				layout.Children.Add(label);

				var entry = new Entry { Placeholder = "Answer here..." };
				layout.Children.Add(entry);
			}



			var scrollView = new ScrollView { Content = layout };
			this.Content = scrollView;
            */

		}

        async void OnClickedA(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveySectionA(theSurvey));
        }
        async void OnClickedB(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SurveyPages.SurveySectionB(theSurvey));
        }
        async void OnClickedC(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
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
            //await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
        }
        async void OnClickedH(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
        }
        async void OnClickedI(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
        }
        async void OnClickedJ(object sender, EventArgs args)
        {
            //await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
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