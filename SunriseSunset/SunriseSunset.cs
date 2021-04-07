using Newtonsoft.Json;
using RestSharp;
using System;

namespace SunriseSunset
{
	class SunriseSunset : ISunsetSunrise
	{
		public DateTime WhenIsSunrise(DateTime date, double longitude)
		{
			RestClient restClient = new RestClient { BaseUrl = new Uri($"https://api.sunrise-sunset.org/json?lat=55.467270&lng=1.0&date=2021-04-07") };
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = restClient.Execute(request);
			DateTime dateTime = JsonConvert.DeserializeObject<SunriseSunsetResult>(response.Content).Results.Sunrise;
			return dateTime;
		}

		public DateTime WhenIsSunset(DateTime date, double longitude)
		{
			return DateTime.Now;
		}

		public DateTime HowCloseToSunrise(DateTime date, double longitude)
		{
			return DateTime.Now;
		}

		public DateTime HowCloseToSunset(DateTime date, double longitude)
		{
			return DateTime.Now;
		}
	}
}
