using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoListEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ContextAction : ContentPage
	{
		private List<ContactData> myContacts;
		List<ContactData> getContact(string searchText = null)
		{
			myContacts = new List<ContactData>
			{
				new ContactData {Name="Mitali",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/1"},
				new ContactData {Name="Ai",Status="Absent",ImageUrl="http://lorempixel.com/100/100/people/2"},
				new ContactData {Name="Saeko",Status="Active",ImageUrl="http://lorempixel.com/100/100/people/3"},
				new ContactData {Name="Sena",Status="Present",ImageUrl="http://lorempixel.com/100/100/people/1"}

			};
			if (String.IsNullOrWhiteSpace(searchText))
				return myContacts;
            //return myContacts.Where(c => c.Name.StartsWith(searchText)).ToList();
			return myContacts.Where(c => c.Name.StartsWith(searchText, StringComparison.Ordinal)).ToList();
		}
		public ContextAction()
		{
			InitializeComponent();

			myListView.ItemsSource = getContact();
			myListView.EndRefresh();
			myListView.IsRefreshing = false;
		}

		private void Call_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as ContactData;
			DisplayAlert("Call", contact.Name, "OK");

		}

		private void Delete_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as ContactData;
			myContacts.Remove(contact);
		}

		private void myListView_Refreshing(object sender, EventArgs e)
		{
			myListView.ItemsSource = getContact();
            myListView.EndRefresh();
		}

		private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			myListView.ItemsSource = getContact(e.NewTextValue);
		}
	}
}
