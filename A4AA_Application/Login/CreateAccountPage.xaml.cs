using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Web;
//using CryptSharp;
using System.Security.Cryptography;
using System.IO;
using System.Text;
using A4AA_Application.SurveyPages;

namespace A4AA_Application.Login
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CreateAccountPage : ContentPage
	{
		Entry[] Entries;
		private Pages p;

		public CreateAccountPage(Pages p)
		{

			InitializeComponent();
			MakeArrays();
			this.BackgroundColor = Color.White;
			this.p = p;

		}

		async void OnClicked(object sender, EventArgs args)
		{
			EntriesWhite();
			if (EntriesValid())
			{
				if (IsMatch())
				{
					await DisplayAlert("", "MADE IT", "OK");
					NewAccount NA = CreateAccount();
					GetSetUser gs = new GetSetUser();
					await gs.AddNewAccountToDB(NA);
					await Navigation.PushAsync(p.mainPg);
				}
			} else
			{
				await DisplayAlert("Alert", "Field(s) Cannot be blank", "OK");
			}

		}

		private NewAccount CreateAccount()
		{
			String fname = Entries[0].Text;
			String lname = Entries[1].Text;
			String username = Entries[2].Text;
			String email = Entries[4].Text;
			//String password = Crypter.SHA512.Crypt(Entries[3].Text);
			//String password = Crypter.Crypt();
			String password = "";
			//System.Web.FormsAuthentication.HashPasswordForStoringInConfigFile(password, MD5);
		

			return new NewAccount(fname, lname, username, email, password);
		}

		private void EntriesWhite()
		{
			foreach(Entry element in Entries)
			{
				element.BackgroundColor = Color.White;
			}
		}

		//Make sure password meets criteria
		//Make sure passwords match
		//Make sure emails match
		//Make sure all fields aren't empty
		//send data to the database
		//if (string.IsNullOrWhiteSpace(value))

		private void MakeArrays()
		{
			Entries = new Entry[7];

			Entry fname = this.FindByName<Entry>("fname");
			Entries[0] = fname;

			Entry lname = this.FindByName<Entry>("lname");
			Entries[1] = lname;
	
			Entry username = this.FindByName<Entry>("username");
			Entries[2] = username;

			Entry password = this.FindByName<Entry>("password");
			Entries[3] = password;

			Entry password2 = this.FindByName<Entry>("password2");
			Entries[5] = password2;

			Entry email = this.FindByName<Entry>("email");
			Entries[4] = email;

			Entry email2 = this.FindByName<Entry>("email2");
			Entries[6] = email2;

		}

		public bool EntriesValid()
		{
			Boolean IsValid = true;
			foreach (Entry element in Entries)
			{
				if (IsBlank(element))
					IsValid = false;
			}
			return IsValid;
		}

		public bool IsMatch()
		{
			Entry email = Entries[4];
			Entry email2 = Entries[6];
			Entry password = Entries[3];
			Entry password2 = Entries[5];
			if (Match(email, email2, "Email"))
			{
				if (Match(password, password2, "Password"))
				{
					
					return true;
				}
			}
			return false;
		}

		public bool Match(Entry ent1, Entry ent2, string Type)
		{
			if (!ent1.Text.Equals(ent2.Text))
			{
				DisplayAlert(Type, Type + "s do not match", "OK");
				return false;
			}
			return true;
		}

		public bool IsBlank(Entry ent)
		{
			if (string.IsNullOrWhiteSpace(ent.Text))
			{
				ent.BackgroundColor = Color.Pink;
				return true;
			}
			return false;
		}
	}
}




