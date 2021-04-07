using System;

namespace SunriseSunset
{
	class SunriseSunsetObject
	{
		public DateTime Sunrise { get; set; }
		public DateTime Sunset { get; set; }
	}

	class SunriseSunsetResult
	{
		public SunriseSunsetObject Results { get; set; }
	}
}
