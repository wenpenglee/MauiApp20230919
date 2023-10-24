namespace MauiApp20230919;

public partial class KidsLearningPage : ContentPage
{
	public KidsLearningPage()
	{
		InitializeComponent();
	}

    private void ImageButton_OnClicked(object sender, EventArgs e)
    {
        ImageButton button = (ImageButton)sender;
        Navigation.PushAsync(new KidsLearningDetailPage(button.CommandParameter.ToString()));
    }
}