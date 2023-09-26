using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20230919;

public partial class FruitPage : ContentPage
{
    public FruitPage()
    {
        InitializeComponent();
    }

    private void FruitDetailButton_OnClicked(object sender, EventArgs e)
    {
        Navigation.PushModalAsync(new FruitDetailPage());

    }
}