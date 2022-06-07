using System.Net.Http.Headers;

namespace project_gui.Api
{
	internal static class Client
	{
		public static HttpClient GetClient()
		{
			HttpClient _httpClient = new();
			_httpClient.BaseAddress = new Uri("https://localhost:7077");
			_httpClient.DefaultRequestHeaders.Accept.Clear();
			_httpClient.DefaultRequestHeaders.Accept
				.Add(new MediaTypeWithQualityHeaderValue("application/json"));

			return _httpClient;
		}
	}
}
