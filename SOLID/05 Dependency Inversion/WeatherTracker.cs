using System;

namespace SOLID._05_Dependency_Inversion
{
    public class WeatherTracker
    {
        string CurrentConditions;

        private readonly IWeather _weather;

        public WeatherTracker(IWeather weather)
        {
            _weather = weather;
        }

        public void SetCurrentConditions(string weatherDescription)
        {
            CurrentConditions = weatherDescription;
            if (weatherDescription == Const.Weather.Rainy || weatherDescription == Const.Weather.Sunny)
            {
                string alert = _weather.GenerateWeatherAlert(weatherDescription);
                Console.WriteLine(alert);
            }
        }
    }
}
