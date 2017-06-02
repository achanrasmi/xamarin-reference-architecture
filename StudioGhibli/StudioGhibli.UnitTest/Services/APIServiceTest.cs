using NUnit.Framework;
using System;
using StudioGhibli.Core.Services;
using System.Threading.Tasks;

namespace StudioGhibli.UnitTest.Services
{
	[TestFixture]
	public class APIServiceTest
	{
		IAPIService apiService;

		[SetUp]
		public void Setup()
		{
			apiService = apiService ?? new APIService();
		}

		[TestFixtureTearDown]
		public void TestFixtureTearDown()
		{
			apiService = null;
		}

		[Test]
		public async Task ShouldReturnNotNullWhenGettingFilms()
		{
			var result = await apiService.GetFilms();
			Assert.IsNotNull(result);
		}

		[Test]
		public async Task ShouldReturnNotEmptyWhenGettingFilms()
		{
			var result = await apiService.GetFilms();
			Assert.IsNotEmpty(result);
		}

		[Test]
		public async Task ShouldReturnNotNullWhenGettingPeople()
		{
			var result = await apiService.GetPeople();
			Assert.IsNotNull(result);
		}

		[Test]
		public async Task ShouldReturnNotEmptyWhenGettingPeople()
		{
			var result = await apiService.GetPeople();
			Assert.IsNotEmpty(result);
		}

		[Test]
		public async Task ShouldReturnNotNullWhenGettingLocations()
		{
			var result = await apiService.GetLocations();
			Assert.IsNotNull(result);
		}

		[Test]
		public async Task ShouldReturnNotEmptyWhenGettingLocations()
		{
			var result = await apiService.GetLocations();
			Assert.IsNotEmpty(result);
		}

		[Test]
		public async Task ShouldReturnNotNullWhenGettingVehicles()
		{
			var result = await apiService.GetVehicles();
			Assert.IsNotNull(result);
		}

		[Test]
		public async Task ShouldReturnNotEmptyWhenGettingVehicles()
		{
			var result = await apiService.GetVehicles();
			Assert.IsNotEmpty(result);
		}

		[Test]
		public async Task ShouldReturnNotNullWhenGettingSpecies()
		{
			var result = await apiService.GetSpecies();
			Assert.IsNotNull(result);
		}

		[Test]
		public async Task ShouldReturnNotEmptyWhenGettingSpecies()
		{
			var result = await apiService.GetSpecies();
			Assert.IsNotEmpty(result);
		}
	}
}
