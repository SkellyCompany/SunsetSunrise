using System;

namespace SunriseSunset
{
	class UserInput
	{
		private bool _quit;


		public void Initialize()
		{
			SunriseSunset sunriseSunset = new SunriseSunset();
			Console.WriteLine("Choose a method to run");
			Console.WriteLine("1. WhenIsSunrise");
			Console.WriteLine("2. WhenIsSunset");
			Console.WriteLine("3. HowCloseToSunrise");
			Console.WriteLine("4. HowCloseToSunset");
			Console.WriteLine();
			do
			{
				string input = Console.ReadLine();
				if (!input.ToUpper().Equals("X"))
				{
					bool isNumber = int.TryParse(input, out int numberChosen);
					if (isNumber && numberChosen >= 1 && numberChosen <= 4)
					{
						UseSunsetSunrise(sunriseSunset, numberChosen);
					}
					else if (!isNumber)
					{
						Console.WriteLine("The value you inserted was not a number.");
					}
					else
					{
						Console.WriteLine("The value you inserted was not an option.");
					}
				}
				else
				{
					_quit = true;
				}
			} while (!_quit);
		}

		private void UseSunsetSunrise(ISunsetSunrise sunsetSunrise, int number)
		{
			Console.WriteLine();
			switch (number)
			{
				case 1:
					{
						Console.Write("Longitude: ");
						double longitude = double.Parse(Console.ReadLine());
						DateTime dateTime = sunsetSunrise.WhenIsSunrise(DateTime.Now, longitude);
						Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
						break;
					}
				case 2:
					{
						Console.Write("Longitude: ");
						double longitude = double.Parse(Console.ReadLine());
						DateTime dateTime = sunsetSunrise.WhenIsSunset(DateTime.Now, longitude);
						Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
						break;
					}
				case 3:
					{
						Console.Write("Longitude: ");
						double longitude = double.Parse(Console.ReadLine());
						DateTime dateTime = sunsetSunrise.HowCloseToSunrise(DateTime.Now, longitude);
						Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
						break;
					}
				case 4:
					{
						Console.Write("Longitude: ");
						double longitude = double.Parse(Console.ReadLine());
						DateTime dateTime = sunsetSunrise.HowCloseToSunset(DateTime.Now, longitude);
						Console.WriteLine(dateTime.ToString("yyyy-MM-dd HH:mm:ss"));
						break;
					}
			}
			Console.WriteLine($"Executed method {number}");
			Console.WriteLine();
		}
	}
}
