using System;
using Xunit;

namespace SunriseSunset.Tests
{
	public class SunriseSunsetTest
	{
        [Fact]
        public void Get_SunriseInvalidLongitude_ThrowArguementInvalidException()
        {
            //Arrange
            DateTime dateTime = DateTime.Now;
            double invalidLongitude = 181;
            ISunsetSunrise sunsetSunrise = new SunriseSunset();

            //Act
            void actual() => sunsetSunrise.WhenIsSunrise(dateTime, invalidLongitude);

            //Assert
            Assert.Throws<ArgumentException>(actual);
        }

        [Fact]
        public void Get_SunsetInvalidLongitude_ThrowArguementInvalidException()
        {
            //Arrange
            DateTime dateTime = DateTime.Now;
            double invalidLongitude = 181;
            ISunsetSunrise sunsetSunrise = new SunriseSunset();

			//Act
			void actual() => sunsetSunrise.WhenIsSunset(dateTime, invalidLongitude);

			//Assert
			Assert.Throws<ArgumentException>(actual);
        }

        [Fact]
        public void Get_SunriseOccured_ReturnsNextDaySunrise()
        {
            //Arrange
            DateTime expected = DateTime.Parse("0001-01-01T00:16:36.0000000");

            DateTime dateTime = DateTime.Parse("2021-04-07 20:00:00");
            double longitude = 8.449080;
            ISunsetSunrise sunsetSunrise = new SunriseSunset();

            //Act
            DateTime actual = sunsetSunrise.HowCloseToSunrise(dateTime, longitude);

            //Assert
            Assert.Equal(expected, actual);
        }

		[Fact]
		public void Get_SunriseOccuring_ReturnsTodaySunrise()
		{
            //Arrange
            DateTime expected = DateTime.Parse("0001-01-01T02:39:39.0000000");

            DateTime dateTime = DateTime.Parse("2021-04-07 04:00:00");
            double longitude = 8.449080;
            ISunsetSunrise sunsetSunrise = new SunriseSunset();

            //Act
            DateTime actual = sunsetSunrise.HowCloseToSunrise(dateTime, longitude);

            //Assert
            Assert.Equal(expected, actual);
        }

		[Fact]
		public void Get_SunsetOccured_ReturnsNextDaySunset()
		{
            //Arrange
            DateTime expected = DateTime.Parse("0001-01-01T00:16:36.0000000");

            DateTime dateTime = DateTime.Parse("2021-04-07 20:00:00");
            double longitude = 8.449080;
            ISunsetSunrise sunsetSunrise = new SunriseSunset();

            //Act
            DateTime actual = sunsetSunrise.HowCloseToSunset(dateTime, longitude);

            //Assert
            Assert.Equal(expected, actual);
        }

		[Fact]
		public void Get_SunsetOccuring_ReturnsTodaySunset()
		{
            //Arrange
            DateTime expected = DateTime.Parse("0001-01-01T16:16:36.0000000");

            DateTime dateTime = DateTime.Parse("2021-04-07 04:00:00");
            double longitude = 8.449080;
            ISunsetSunrise sunsetSunrise = new SunriseSunset();

            //Act
            DateTime actual = sunsetSunrise.HowCloseToSunset(dateTime, longitude);

            //Assert
            Assert.Equal(expected, actual);
        }
	}
}
