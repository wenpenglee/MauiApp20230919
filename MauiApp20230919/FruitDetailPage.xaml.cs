using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20230919;

public partial class FruitDetailPage : ContentPage
{
    public FruitDetailPage()
    {
        InitializeComponent();
    }

    private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
    {
        
        Navigation.PopModalAsync();
    }
}