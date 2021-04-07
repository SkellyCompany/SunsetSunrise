using System;

namespace SunriseSunset
{
    public interface ISunsetSunrise
    {
        /*
         * This method will take in a date, logitude that the user provided and will calculate when sunrise will occur.
         * There are two options for checking when is sunrise and sunset. 
         * Either getting data off a free website or using the sunrise equation. Both are acceptable in this case.
         * 
         * This method should return the time when sunrise should happen.
         * 
         * The user provided date should be in this format : 2021-07-15 01:15:23
         * Outputed date should be in a similar format.
         */
        DateTime WhenIsSunrise(DateTime date, double longitude);
        /*
         *  This method will take in a date, logitude that the user provided and will calculate when sunset will occur.
         */
        DateTime WhenIsSunset(DateTime date, double longitude);

        /*
         *  This method will take in a date, logitude that the user provided and will calculate in how long until the next sunrise.
         *  If sunrise is currently occuring, this function should output when the next sunrise will occur.
         */
        DateTime HowCloseToSunrise(DateTime date, double longitude);

        /*
         *  This method will take in a date, logitude that the user provided and will calculate in how long until the next sunset.
         *  If sunset is currently occuring, this function should output when the next sunset will occur.
         */
        DateTime HowCloseToSunset(DateTime date, double longitude);
    }
}
