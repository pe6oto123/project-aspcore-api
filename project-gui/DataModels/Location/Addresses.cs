using project_gui.Api;
using System.Net.Http.Json;

namespace project_gui.DataModels
{
	public class Addresses
	{
		public int? Id { get; set; }
		public string? MainAddress { get; set; }
		public virtual Cities? City { get; set; }
	}

	public class AddressesController
	{
		private static HttpResponseMessage? response;

		internal static async Task<Addresses?> GetAddressById(int? id)
		{
			response = await Client.GetClient().GetAsync($"api/Addresses/{id}");
			if (response.IsSuccessStatusCode)
			{
				return await response.Content.ReadFromJsonAsync<Addresses>();
			}
			return null;
		}
	}
}
