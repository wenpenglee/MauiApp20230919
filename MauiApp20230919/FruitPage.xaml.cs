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
        List<Fruit> _fruitList = new List<Fruit>()
        {
            new Fruit() { Name = "Apple", Image = "apple.png", Description = "This is an apple"},
            new Fruit() { Name = "Orange", Image = "orange.png", Description = "This is an orange"},
            new Fruit() { Name = "Banana", Image = "banana.png", Description = "This is a banana"},
            new Fruit() { Name = "Kiwi", Image = "kiwi.png", Description = "This is a kiwi"},
            new Fruit() { Name = "Strawberry", Image = "strawberry.png", Description = "This is a strawberry"},
            new Fruit() { Name = "Pineapple", Image = "pineapple.png", Description = "This is a pineapple"},
            new Fruit() { Name = "Watermelon", Image = "watermelon.png", Description = "This is a watermelon"},
            new Fruit() { Name = "Grapes", Image = "grape.png", Description = "This is a grapes"},
        };
        
        InitializeComponent();
        FruitListView.ItemsSource = _fruitList;
    }

    // private void FruitDetailButton_OnClicked(object sender, EventArgs e)
    // {   
    //     if (e.SelectedItem == null)
    //         return;
    //     var selectedItem = e.SelectedItem as Fruit;
    //     Navigation.PushModalAsync(new FruitDetailPage(selectedItem.Name, selectedItem.Image, selectedItem.Description));
    //
    // }

    private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var selectedItem = e.SelectedItem as Fruit;
        Navigation.PushAsync(new FruitDetailPage(selectedItem?.Name, selectedItem?.Image, selectedItem?.Description));
    }
}