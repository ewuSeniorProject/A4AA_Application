namespace A4AA_Application.Login
{
	public class NewAccount
	{
		private string fname { get; set; }
		private string lname { get; set; }
		private string user_name { get; set; }
		private string email { get; set; }
		private string password;
		private string role = "level 1";
		private string active = "true";

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