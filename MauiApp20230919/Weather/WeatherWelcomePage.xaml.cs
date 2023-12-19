using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20230919.Weather;

public partial class WeatherWelcomePage : ContentPage
{
    public WeatherWelcomePage()
    {
        InitializeComponent();
    }
    
    

    private void BtnGetStarted_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new WeatherPage());
    }
}