using MauiApp20230919.Models.WeatherModels;
using Newtonsoft.Json;
namespace MauiApp20230919.Services;

    public static class WeatherAPIService
    {
        public static async Task<Root> GetWeatherByLatLon(double lat, double lon)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(
                $"https://api.openweathermap.org/data/2.5/forecast?lat={lat}&lon={lon}&appid=911ca935ac5a00427d30706f8e4b4cfd&units=metric&lang=zh_tw");
            return JsonConvert.DeserializeObject<Root>(response);
        }
        
        public static async Task<Root> GetWeatherByCity(string cityName)
        {
            var httpClient = new HttpClient();
            var response = await httpClient.GetStringAsync(
                $"https://api.openweathermap.org/data/2.5/forecast?q={cityName}&appid=911ca935ac5a00427d30706f8e4b4cfd&units=metric&lang=zh_tw");
            return JsonConvert.DeserializeObject<Root>(response);
        }
    }
