using System;
using Xamarin.Forms;

namespace A4AA_Application
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			Entry username = this.FindByName<Entry>("UsernameEnt");
			Entry password = this.FindByName<Entry>("PasswordEnt");
			username.Text = Utils.Settings.LastUsedUsername;
			password.Text = Utils.Settings.LastUsedPassword;
		}
		
		async void OnClicked1(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new Login.CreateAccountPage());
		}

		async void OnClicked2(object sender, EventArgs args)
		{
			await Navigation.PushAsync(new SurveyPages.MainSurveyPage());
		}

		void OnClicked3(object sender, EventArgs args)
		{
			Entry username = this.FindByName<Entry>("UsernameEnt");
			String userNameText = username.Text;
			Entry password = this.FindByName<Entry>("PasswordEnt");
			String passwordText = password.Text;
			Utils.Settings.LastUsedUsername = userNameText;
			Utils.Settings.LastUsedPassword = passwordText;
		}
		
	}
}
