using System;

namespace A4AA_Application.Login
{
	[Serializable]
	public class NewAccount
	{
		public string fname { get; set; }
		public string lname { get; set; }
		public string user_name { get; set; }
		public string email { get; set; }
		public string password { get; set; }
		public string role = "user";
		public string active = "yes";

		public NewAccount(string fname, string lname, string username, string email, string password)
		{
			this.fname = fname;
			this.lname = lname;
			user_name = username;
			this.email = email;
			this.password = password;
		}

	}
}