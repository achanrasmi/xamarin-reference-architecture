//using System.Collections.Generic;
//using System.Threading.Tasks;
//using NUnit.Framework;
//using ReferenceArchitecture.Core.Services;

//TODO: Fix the following error
//System.Net.Http.HttpRequestException : An error occurred while sending the request
//  ----> System.Net.WebException : Error: SecureChannelFailure(The authentication or decryption has failed.)
//  ----> System.IO.IOException : The authentication or decryption has failed.
//  ----> System.IO.IOException : The authentication or decryption has failed.
//  ----> Mono.Security.Protocol.Tls.TlsException : The authentication or decryption has failed.

//namespace ReferenceArchitecture.UnitTest
//{
//	[TestFixture]
//	public class BaseNetworkServiceTest
//	{
//		TestNetworkService service;

//		[SetUp]
//		public void Setup()
//		{
//			service = new TestNetworkService();
//		}

//		[TearDown]
//		public void TearDown()
//		{
//			service = null;
//		}

//		[Test]
//		public async Task ShouldReturnNotNullWhenGettingTestPosts()
//		{
//			var posts = await service.GetTestPostsAsync();
//			Assert.IsNotNull(posts);
//		}

//		class TestNetworkService : BaseNetworkService
//		{
//			public override string BaseAddress => "https://jsonplaceholder.typicode.com";

//			public Task<List<TestPost>> GetTestPostsAsync()
//			{
//				return GetAsync<List<TestPost>>("/posts");
//			}
//		}

//		class TestPost
//		{
//			public int UserId { get; set; }
//			public int Id { get; set; }
//			public string Title { get; set; }
//			public string Body { get; set; }
//		}
//	}
//}
