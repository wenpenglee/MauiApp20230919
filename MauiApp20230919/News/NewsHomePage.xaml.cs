using MauiApp20230919.Models;
using MauiApp20230919.Services;

namespace MauiApp20230919.News;

public partial class NewsHomePage : ContentPage
{
    public List<Article> ArticlesList;

    public List<Category> CategoryList = new List<Category>()
    {
        new Category(){Name = "World", ImageUrl = "world.png"},
        new Category(){Name = "Nation", ImageUrl = "nation.png"},
        new Category(){Name = "Business", ImageUrl = "business.png"},
        new Category(){Name = "Technology", ImageUrl = "technology.png"},
        new Category(){Name = "Entertainment", ImageUrl = "entertainment"},
        new Category(){Name = "Sports", ImageUrl = "sports.png"},
        new Category(){Name = "Science", ImageUrl = "science.png"},
        new Category(){Name = "Health", ImageUrl = "health.png"},
    };
	public NewsHomePage()
	{
		InitializeComponent();
        
        ArticlesList = new List<Article>();
        GetBreakingNews();
        CvCategories.ItemsSource = CategoryList;
    }

    private async void GetBreakingNews()
    {
        var apiService = new ApiService();
        var articles = await apiService.GetNews("general");
        foreach (var article in articles.Articles)
        {
            ArticlesList.Add(article);
        }

        CvNews.ItemsSource = ArticlesList;
    }

    private void CvCategories_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        Console.WriteLine(sender.ToString());
        var selectedItem = e.CurrentSelection.FirstOrDefault() as Category;
        if (selectedItem != null) { return; }
        Navigation.PushAsync(new NewsListPage(selectedItem.Name));
        ((CollectionView)sender).SelectedItem = null;
    }
}