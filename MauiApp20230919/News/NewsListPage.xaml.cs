using MauiApp20230919.Models;
using MauiApp20230919.Services;

namespace MauiApp20230919.News;

public partial class NewsListPage : ContentPage
{
    public List<Article> ArticlesList;

	public NewsListPage(string categoryName)
	{
		InitializeComponent();
        Title = categoryName;
        GetNews(categoryName);
        ArticlesList = new List<Article>();
    }

    private async void GetNews(string categoryName)
    {
        var apiService = new ApiService();
        var newsResult = await apiService.GetNews(categoryName);
        foreach (var item in newsResult.Articles)
        {
            ArticlesList.Add(item);
        }

        CvNews.ItemsSource = ArticlesList;
    }

    private void CvNews_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Article;
        if (selectedItem != null) { return;}

        Navigation.PushAsync(new NewsDetailPage(selectedItem));
        ((CollectionView)sender).SelectedItem = null;
    }
}