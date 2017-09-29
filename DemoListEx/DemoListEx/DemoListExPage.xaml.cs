using Xamarin.Forms;
using System.Collections.Generic;

namespace DemoListEx
{
    public partial class DemoListExPage : ContentPage
    {
        public DemoListExPage()
        {
            InitializeComponent();
            //var names = new List<string>{
            //	"Mitali",
            //	"Sena",
            //	"Ai",
            //	"Saeko",
            //	"Hanna",
            //	"Shinji"
            //};

            //myListView.ItemsSource = names;

            myListView.ItemsSource = new List<ContactData>{
                new ContactData{Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
                new ContactData{Name="Sena",Status="Abesent",ImageUrl="http://lorempixel.com/100/100/people/2"},
                new ContactData{Name="Ai",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/3"},
                new ContactData{Name="Saeko",Status="Present",ImageUrl="http://lorempixel.com/100/100/people/1"}
            };
		}
    }
}
