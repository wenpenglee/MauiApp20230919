namespace MauiApp20230919
{
    public partial class MainPage : ContentPage
    {
        // int count = 0;
        private string _account = "wenpenglee";
        private string _password = "12345678";

        public MainPage()
        {
            InitializeComponent();
        }

        //private void OnCounterClicked(object sender, EventArgs e)
        //{
        //    count++;

        //    if (count == 1)
        //        CounterBtn.Text = $"Clicked {count} time";
        //    else
        //        CounterBtn.Text = $"Clicked {count} times";

        //    SemanticScreenReader.Announce(CounterBtn.Text);
        //}

        private void LoginClicked(object sender, EventArgs e)
        {

            if(LoginAccountEntry.Text == _account && LoginPasswordEntry.Text == _password)
            {
                DisplayAlert("Notification", "Success", "OK");
            }
            else
            {
                DisplayAlert("Notification", "Failed", "OK");
                LoginPasswordEntry.Text = "";
                LoginAccountEntry.Text = "";
            }
        }
    }
}