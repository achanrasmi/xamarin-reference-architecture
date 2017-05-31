using System;
namespace StudioGhibli.Core.Model
{
	public class Species
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Classification { get; set; }
		public string EyeColors { get; set; }
		public string HairColors { get; set; }
		public string[] People { get; set; }
		public string[] Films { get; set; }
	}
}
