using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiApp20230919.Models.WeatherModels;
using MauiApp20230919.Services;

namespace MauiApp20230919.Weather;

public partial class WeatherPage : ContentPage
{
    private double _latitude;
    private double _longitude;
    public List<Models.WeatherModels.List> WeatherList;
    public WeatherPage()
    {
        InitializeComponent();
        WeatherList = new List<Models.WeatherModels.List>();
    }
    
    protected override async void OnAppearing()
    {
        base.OnAppearing();
        await GetLocation();
        await GetWeatherDataByLocation(_latitude, _longitude);
        
    }

    public async Task GetLocation()
    {
        var location = await Geolocation.GetLocationAsync();
        if (location != null)
        {
            _latitude = location.Latitude;
            _longitude = location.Longitude;
        }
    }

    public async Task GetWeatherDataByLocation(double latitude, double longitude)
    {
        await GetLocation();
        var result = await WeatherAPIService.GetWeatherByLatLon(_latitude, _longitude);
        UpdateUI(result);
        
    }
    
    private async Task GetWeatherDataByCity(string city)
    {
        var result = await WeatherAPIService.GetWeatherByCity(city);
        foreach(var item in result.list)
        {
            WeatherList.Add(item);
        }
        CvWeather.ItemsSource = WeatherList;
        UpdateUI(result);
    }
    
    private async void TapLocation_Tapped(object sender, TappedEventArgs e)
    {
        await GetLocation();
        await GetWeatherDataByLocation(_latitude, _longitude);
    }

    private async void ImageButton_OnClicked(object sender, EventArgs e)
    {
        var response = await DisplayPromptAsync(title: "Search", message:"Please enter a city name", placeholder: "Search weather by City", accept: "Search", cancel: "Cancel");
        if (response != null)
        {
            await GetWeatherDataByCity(response);
        }
    }



    public void UpdateUI(dynamic result)
    {
        foreach (var item in result.list)
        {
            WeatherList.Add(item);
        }
        
        
        LblCity.Text = result.city.name;
        LblWeatherDescription.Text = result.list[0].weather[0].description;
        LblTemperature.Text = result.list[0].main.temperature + "°C";
        LblHumidity.Text = result.list[0].main.humidity + "%";
        LblWind.Text =  result.list[0].wind.speed + "km/h";
        ImgWeatherIcon.Source = result.list[0].weather[0].customIcon;
        
        CvWeather.ItemsSource = WeatherList;
    }
}