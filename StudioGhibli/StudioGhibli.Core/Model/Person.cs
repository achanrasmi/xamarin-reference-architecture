using System;
namespace StudioGhibli.Core.Model
{
	public class Person
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Gender { get; set; }
		public string Age { get; set; }
		public string EyeColor { get; set; }
		public string HairColor { get; set; }
		public string[] Films { get; set; }
		public string Species { get; set; }
	}
}
