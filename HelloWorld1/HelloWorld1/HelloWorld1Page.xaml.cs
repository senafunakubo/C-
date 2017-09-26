using Xamarin.Forms;

namespace HelloWorld1
{
    public partial class HelloWorld1Page : ContentPage
    {
        public HelloWorld1Page()
        {
            InitializeComponent();
            slider1.Value = 0.5;
            if(Device.RuntimePlatform.Equals("iOS")){
                Padding = new Thickness(0, 20, 0, 0);
            }
            else if(Device.RuntimePlatform.Equals("Android")){
                Padding = new Thickness(10, 20, 0, 0);
            }
            else if(Device.RuntimePlatform.Equals("Windows")){
                Padding = new Thickness(10, 20, 30, 0);
            }
        }

        private void Button_Clicked(object sender, System.EventArgs e){
            DisplayAlert("Title","Hello to xamarin.forms","OK");
        }
    }
}
