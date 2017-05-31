using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using StudioGhibli.Core.Model;

namespace StudioGhibli.Core.Services
{
	/// <summary>
	/// Interface for API Service.
	/// </summary>
	public interface IAPIService
	{
		/// <summary>
		/// Gets the films.
		/// </summary>
		/// <returns>The films.</returns>
		Task<IEnumerable<Film>> GetFilms();

		/// <summary>
		/// Gets the people.
		/// </summary>
		/// <returns>The people.</returns>
		Task<IEnumerable<Person>> GetPeople();

		/// <summary>
		/// Gets the locations.
		/// </summary>
		/// <returns>The locations.</returns>
		Task<IEnumerable<Location>> GetLocations();

		/// <summary>
		/// Gets the vehicles.
		/// </summary>
		/// <returns>The vehicles.</returns>
		Task<IEnumerable<Vehicle>> GetVehicles();

		/// <summary>
		/// Gets the species.
		/// </summary>
		/// <returns>The species.</returns>
		Task<IEnumerable<Species>> GetSpecies();
	}
}
