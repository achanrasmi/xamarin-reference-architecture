using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ReferenceArchitecture.Core.Services
{
	/// <summary>
	/// Base network service.
	/// </summary>
	public abstract class BaseNetworkService : IDisposable
	{
		/// <summary>
		/// Gets the base address.
		/// </summary>
		/// <value>The base address.</value>
		public abstract string BaseAddress { get; }

		/// <summary>
		/// Gets the json settings.
		/// </summary>
		/// <value>The json settings.</value>
		public JsonSerializerSettings JsonSettings { get; protected set; }

		readonly HttpClient client;

		/// <summary>
		/// Initializes a new instance of the <see cref="T:StudioGhibli.Core.Networking.BaseNetworkService"/> class.
		/// </summary>
		/// <param name="httpClientModifier">Http client modifier.</param>
		protected BaseNetworkService(Action<HttpClient> httpClientModifier = null)
		{
			client = new HttpClient();
			client.BaseAddress = new Uri(BaseAddress);
			httpClientModifier?.Invoke(client);
		}

		/// <summary>
		/// Call GET string based on path
		/// </summary>
		/// <returns>The async.</returns>
		/// <param name="path">Path.</param>
		/// <typeparam name="T">The 1st type parameter.</typeparam>
		protected async Task<T> GetAsync<T>(string path)
		{
			var json = await client.GetStringAsync($"{path}").ConfigureAwait(false);

			return Deserialize<T>(json);
		}

		// Helper method to apply settings if they exist
		T Deserialize<T>(string json) => JsonSettings != null ? JsonConvert.DeserializeObject<T>(json, JsonSettings) : JsonConvert.DeserializeObject<T>(json);

		#region IDisposable Support
		bool disposedValue; // To detect redundant calls

		protected virtual void Dispose(bool disposing)
		{
			if (!disposedValue)
			{
				if (disposing)
				{
					client.Dispose();
				}

				disposedValue = true;
			}
		}

		// This code added to correctly implement the disposable pattern.
		public void Dispose()
		{
			// Do not change this code. Put cleanup code in Dispose(bool disposing) above.
			Dispose(true);
		}
		#endregion
	}
}
