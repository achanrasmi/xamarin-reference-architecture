using NUnit.Framework;
using System;
using StudioGhibli.Core.Services;
using System.Threading.Tasks;

namespace StudioGhibli.UnitTest.Services
{
	/// <summary>
	/// API Service test.
	/// </summary>
	[TestFixture]
	public class APIServiceTest
	{
		IAPIService apiService;

		/// <summary>
		/// Setup before each test
		/// </summary>
		[SetUp]
		public void Setup()
		{
			apiService = apiService ?? new APIService();
		}

		/// <summary>
		/// Tests the get films returns not null.
		/// </summary>
		/// <returns>The get films returns not null.</returns>
		[Test]
		public async Task TestGetFilmsReturnsNotNull()
		{
			var result = await apiService.GetFilms();
			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Tests the get films returns not empty.
		/// </summary>
		/// <returns>The get films returns not empty.</returns>
		[Test]
		public async Task TestGetFilmsReturnsNotEmpty()
		{
			var result = await apiService.GetFilms();
			Assert.IsNotEmpty(result);
		}

		/// <summary>
		/// Tests the get people returns not null.
		/// </summary>
		/// <returns>The get people returns not null.</returns>
		[Test]
		public async Task TestGetPeopleReturnsNotNull()
		{
			var result = await apiService.GetPeople();
			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Tests the get people returns not empty.
		/// </summary>
		/// <returns>The get people returns not empty.</returns>
		[Test]
		public async Task TestGetPeopleReturnsNotEmpty()
		{
			var result = await apiService.GetPeople();
			Assert.IsNotEmpty(result);
		}

		/// <summary>
		/// Tests the get locations returns not null.
		/// </summary>
		/// <returns>The get locations returns not null.</returns>
		[Test]
		public async Task TestGetLocationsReturnsNotNull()
		{
			var result = await apiService.GetLocations();
			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Tests the get locations returns not empty.
		/// </summary>
		/// <returns>The get locations returns not empty.</returns>
		[Test]
		public async Task TestGetLocationsReturnsNotEmpty()
		{
			var result = await apiService.GetLocations();
			Assert.IsNotEmpty(result);
		}

		/// <summary>
		/// Tests the get vehicles returns not null.
		/// </summary>
		/// <returns>The get vehicles returns not null.</returns>
		[Test]
		public async Task TestGetVehiclesReturnsNotNull()
		{
			var result = await apiService.GetVehicles();
			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Tests the get vehicles returns not empty.
		/// </summary>
		/// <returns>The get vehicles returns not empty.</returns>
		[Test]
		public async Task TestGetVehiclesReturnsNotEmpty()
		{
			var result = await apiService.GetVehicles();
			Assert.IsNotEmpty(result);
		}

		/// <summary>
		/// Tests the get species returns not null.
		/// </summary>
		/// <returns>The get species returns not null.</returns>
		[Test]
		public async Task TestGetSpeciesReturnsNotNull()
		{
			var result = await apiService.GetSpecies();
			Assert.IsNotNull(result);
		}

		/// <summary>
		/// Tests the get species returns not empty.
		/// </summary>
		/// <returns>The get species returns not empty.</returns>
		[Test]
		public async Task TestGetSpeciesReturnsNotEmpty()
		{
			var result = await apiService.GetSpecies();
			Assert.IsNotEmpty(result);
		}
	}
}
