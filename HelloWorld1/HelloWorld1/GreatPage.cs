using System;

using Xamarin.Forms;

namespace HelloWorld1
{
    public class GreatPage : ContentPage
    {
        public GreatPage()
        {
            InitializeComponent();
            Content = new Label
            {
                Text = "Hello World",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };
        }
    }
}

