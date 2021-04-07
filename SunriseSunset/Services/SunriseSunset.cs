using Newtonsoft.Json;
using RestSharp;
using System;

namespace SunriseSunset
{
	class SunriseSunset : ISunsetSunrise
	{
		public DateTime WhenIsSunrise(DateTime date, double longitude)
		{
			string uri = $"https://api.sunrise-sunset.org/json?lat=55.467270&lng=" + longitude + "&date=" + date.ToString("yyyy-MM-dd");
			RestClient restClient = new RestClient { BaseUrl = new Uri(uri) };
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = restClient.Execute(request);
			DateTime dateTime = JsonConvert.DeserializeObject<SunriseSunsetResult>(response.Content).Results.Sunrise;
			return dateTime;
		}

		public DateTime WhenIsSunset(DateTime date, double longitude)
		{
			string uri = $"https://api.sunrise-sunset.org/json?lat=55.467270&lng=" + longitude + "&date=" + date.ToString("yyyy-MM-dd");
			RestClient restClient = new RestClient { BaseUrl = new Uri(uri) };
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = restClient.Execute(request);
			DateTime dateTime = JsonConvert.DeserializeObject<SunriseSunsetResult>(response.Content).Results.Sunset;
			return dateTime;
		}

		public DateTime HowCloseToSunrise(DateTime date, double longitude)
		{
			string uri = $"https://api.sunrise-sunset.org/json?lat=55.467270&lng=" + longitude + "&date=" + date.ToString("yyyy-MM-dd") + "&formatted=0";
			RestClient restClient = new RestClient { BaseUrl = new Uri(uri) };
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = restClient.Execute(request);
			DateTime dateTime = JsonConvert.DeserializeObject<SunriseSunsetResult>(response.Content).Results.Sunrise;
			TimeSpan timeUntilSunrise = dateTime.Subtract(DateTime.Now);
			if (timeUntilSunrise.Ticks < 0.0f)
			{
				date = date.AddDays(1);
				return HowCloseToSunrise(date, longitude);
			}
			else
			{
				return new DateTime() + timeUntilSunrise;
			}
		}

		public DateTime HowCloseToSunset(DateTime date, double longitude)
		{
			string uri = $"https://api.sunrise-sunset.org/json?lat=55.467270&lng=" + longitude + "&date=" + date.ToString("yyyy-MM-dd") + "&formatted=0";
			RestClient restClient = new RestClient { BaseUrl = new Uri(uri) };
			RestRequest request = new RestRequest(Method.GET);
			IRestResponse response = restClient.Execute(request);
			DateTime dateTime = JsonConvert.DeserializeObject<SunriseSunsetResult>(response.Content).Results.Sunset;
			TimeSpan timeUntilSunrise = dateTime.Subtract(DateTime.Now);
			if (timeUntilSunrise.Ticks < 0.0f)
			{
				date = date.AddDays(1);
				return HowCloseToSunrise(date, longitude);
			}
			else
			{
				return new DateTime() + timeUntilSunrise;
			}
		}
	}
}
