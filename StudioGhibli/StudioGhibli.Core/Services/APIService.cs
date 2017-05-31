using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using ReferenceArchitecture.Core.Services;
using StudioGhibli.Core.Model;

namespace StudioGhibli.Core.Services
{
	/// <summary>
	/// API Service Implementation.
	/// </summary>
	public class APIService : BaseNetworkService, IAPIService
	{
		public override string BaseAddress => "https://ghibliapi.herokuapp.com";

		public override JsonSerializerSettings JsonSettings => new JsonSerializerSettings
		{
			ContractResolver = new DefaultContractResolver
			{
				NamingStrategy = new SnakeCaseNamingStrategy(true, false)
			}
		};

		public Task<IEnumerable<Film>> GetFilms()
		{
			return GetAsync<IEnumerable<Film>>("/films");
		}

		public Task<IEnumerable<Location>> GetLocations()
		{
			return GetAsync<IEnumerable<Location>>("/locations");
		}

		public Task<IEnumerable<Person>> GetPeople()
		{
			return GetAsync<IEnumerable<Person>>("/people");
		}

		public Task<IEnumerable<Species>> GetSpecies()
		{
			return GetAsync<IEnumerable<Species>>("/species");
		}

		public Task<IEnumerable<Vehicle>> GetVehicles()
		{
			return GetAsync<IEnumerable<Vehicle>>("/vehicles");
		}
	}
}
