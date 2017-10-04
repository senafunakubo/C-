using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Images
{
    public partial class DownloadedImage : ContentPage
    {
        public DownloadedImage()
        {
            InitializeComponent();
            embeddedImage.Source = ImageSource.FromResource("Images.beach.jpg");
        }
    }
}
