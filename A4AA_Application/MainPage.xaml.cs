using A4AA_Application.SurveyClasses;
using A4AA_Application.SurveyPages;
using System;
using Xamarin.Forms;

namespace A4AA_Application
{
	public partial class MainPage : ContentPage
	{
		private Survey theSurvey;

		public MainPage()
		{
			InitializeComponent();
            this.Title = "Welcome!";
            /*Entry username = this.FindByName<Entry>("UsernameEnt");
			Entry password = this.FindByName<Entry>("PasswordEnt");
			username.Text = Utils.Settings.LastUsedUsername;
			password.Text = Utils.Settings.LastUsedPassword;*/
            if (theSurvey == null)
            {
                theSurvey = new Survey();
            }
		}
		
		/*async void OnClicked1(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new Login.CreateAccountPage(p));
		}*/

		async void OnClicked2(object sender, EventArgs args)
		{
            //await Navigation.PushAsync(new MainSurveyPage(theSurvey));
            await Navigation.PushAsync(new MainSurveyPage(theSurvey));
        }

        /*async void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainSurveyPage(theSurvey));
        }*/

        /*void OnClicked3(object sender, EventArgs args)
		{
			Entry username = this.FindByName<Entry>("UsernameEnt");
			String userNameText = username.Text;
			Entry password = this.FindByName<Entry>("PasswordEnt");
			String passwordText = password.Text;
			Utils.Settings.LastUsedUsername = userNameText;
			Utils.Settings.LastUsedPassword = passwordText;
		}*/
    }
}
