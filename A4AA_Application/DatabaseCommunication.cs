using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace A4AA_Application
{
    class DatabaseCommunication
    {
		private HttpClient client;
		private string path;

		public HttpClient Client { get => client; set => client = value; }
		public string Path { get => path; set => path = value; }

		public Task<HttpResponseMessage> send_to_Database(Object o)
		{
			Client = new HttpClient();
			Path = @"http://a4as.mizesolutions.com/post/user/mobile";
			
			var json = JsonConvert.SerializeObject(o);
			var content = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
			return Client.PostAsync(Path, content);
		}
    }
}
