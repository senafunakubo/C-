using System;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Images
{
    public partial class ImagesPage : ContentPage
    {
        public ImagesPage()
        {
            InitializeComponent();
			var ImageSource = new UriImageSource
            {
                Uri = new System.Uri("http://lorempixel.com/1920/1080/city/1/"),
                CachingEnabled = false,
                CacheValidity = TimeSpan.FromHours(1)
            };

			i1.Source = ImageSource;

        }
    }
}
