using System;

namespace SOLID._05_Dependency_Inversion
{
    public interface IWeather
    {
        String GenerateWeatherAlert(String weatherConditions);
    }
}
