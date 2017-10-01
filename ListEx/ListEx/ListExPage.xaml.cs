using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListExPage : ContentPage
	{
		private List<SearchData> myContacts;
		List<SearchData> getContact(string searchText = null)
		{
			myContacts = new List<SearchData>
			{
				new SearchData {Name="Mitali",Status="Active"},
				new SearchData {Name="Ai",Status="Absent"},
				new SearchData {Name="Saeko",Status="Active"},
				new SearchData {Name="Sena",Status="Present"}

			};
			if (String.IsNullOrWhiteSpace(searchText))
				return myContacts;
			return myContacts.Where(c => c.Name.StartsWith(searchText, StringComparison.Ordinal)).ToList();
		}
		public ListExPage()
		{
			InitializeComponent();

			myListView.ItemsSource = getContact();
			myListView.EndRefresh();
			myListView.IsRefreshing = false;
		}

		private void Delete_Clicked(object sender, EventArgs e)
		{
			var menuItem = sender as MenuItem;
			var contact = menuItem.CommandParameter as SearchData;
			myContacts.Remove(contact);
		}

		private void myListView_Refreshing(object sender, EventArgs e)
		{
			myListView.ItemsSource = getContact();
		}

		private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
		{
			myListView.ItemsSource = getContact(e.NewTextValue);
		}
	}
}
