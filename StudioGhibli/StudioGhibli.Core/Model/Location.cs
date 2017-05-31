using System;
namespace StudioGhibli.Core.Model
{
	public class Location
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Climate { get; set; }
		public string Terrain { get; set; }
		public string SurfaceWater { get; set; }
		public string[] Residents { get; set; }
		public string[] Films { get; set; }
	}
}
