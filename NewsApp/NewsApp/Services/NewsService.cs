using System;
using System.Net.Http.Json;
using NewsApp.Model;
namespace NewsApp.Services
{
	public class NewsService
	{
		private HttpClient httpClient;
		private List<News> news = new();
		public NewsService()
		{
			httpClient = new HttpClient();
		}

		public async Task<List<News>> GetNewsAsync()	
		{
			var url = "https://mocki.io/v1/97840557-83a3-4291-b036-6bcad9d672a1";
			var response = await httpClient.GetAsync(url);
			if (response.IsSuccessStatusCode)
			{
				news = await response.Content.ReadFromJsonAsync<List<News>>();
			}
			return news;
        }
	}
}

