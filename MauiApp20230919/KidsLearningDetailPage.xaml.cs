namespace MauiApp20230919;

public partial class KidsLearningDetailPage : ContentPage
{
	public KidsLearningDetailPage(string categoryName)
	{
		InitializeComponent();
		DisplayLearningResult(categoryName);
        Title = categoryName;
    }

    private void DisplayLearningResult(string categoryName)
    {
        LearningData learningData = new();
        switch (categoryName)
        {
            case "Numbers":
                CvKids.ItemsSource = learningData.Numbers; break;
            case "Letters":
                CvKids.ItemsSource = learningData.Letters; break;
            case "Shapes":
                CvKids.ItemsSource = learningData.Shapes; break;
            case "Colors":
                CvKids.ItemsSource = learningData.Colors; break;
            case "Fruits":
                CvKids.ItemsSource = learningData.Fruits; break;
            case "Animals":
                CvKids.ItemsSource = learningData.Animals; break;
            default:
                break;
        }
    }

    private async void CvKids_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        if (e?.CurrentSelection.FirstOrDefault() is not LearningItem selectedItem)
            return;
        await TextToSpeech.SpeakAsync(selectedItem.Name);
    }
}