namespace SOLID._05_Dependency_Inversion
{
    public class Phone : IWeather
    {
        public string GenerateWeatherAlert(string weatherConditions)
        {
            string alert = "It is " + weatherConditions;
            return alert;
        }
    }
}
