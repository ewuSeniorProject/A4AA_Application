using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace A4AA_Application.Login
{
	class GetSetUser
	{
		

		//private async void Connect()
		//{
		//	var client = new HttpClient();
		//	client.BaseAddress = new Uri("localhost:8080");

		//	string jsonData = @"{""username"" : ""myusername"", ""password"" : ""mypassword""}"

		//		var content = new StringContent(jsonData, Encoding.UTF8, "application/json");
		//	HttpResponseMessage response = await client.PostAsync("/foo/login", content);

		//	// this result string should be something like: "{"token":"rgh2ghgdsfds"}"
		//	var result = await response.Content.ReadAsStringAsync();
		//}

		public Task<HttpResponseMessage> AddNewAccountToDB(NewAccount Account)
		{
			var client = new HttpClient();
			var json= JsonConvert.SerializeObject(Account);
			var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
			var path = @"http://a4as.mizesolutions.com/post/user/mobile";
			return client.PostAsync(path, content);
		}
	}
}
