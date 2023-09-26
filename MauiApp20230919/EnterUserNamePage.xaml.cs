using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20230919;

public partial class EnterUserNamePage : ContentPage
{
    public EnterUserNamePage()
    {
        InitializeComponent();
    }

    private void SendToUserNamePage_OnClick(object sender, EventArgs e)
    {
        Navigation.PushAsync(new UserNamePage(EnterUserName.Text));
    }
}