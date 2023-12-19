using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp20230919;

public partial class UserNamePage : ContentPage
{
    public UserNamePage(string userName)
    {
        InitializeComponent();
        LabelUserName.Text = userName;
    }
}