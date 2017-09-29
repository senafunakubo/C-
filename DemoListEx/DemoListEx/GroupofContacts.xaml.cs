using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoListEx
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class GroupofContacts : ContentPage
	{
		public GroupofContacts()
		{
			InitializeComponent();
			myListView.ItemsSource = new List<ContactGroup>
			{
				new ContactGroup("M1","M")
				{
					new ContactData{Name="Mitali", Status="Active"},
					new ContactData{Name="Mary", Status="Sleeping"},
					new ContactData{Name="Mosh", Status="Active"}
				},
				new ContactGroup("S1","S")
				{
					new ContactData{Name="Saeko", Status="Active"},
					new ContactData{Name="Shinji", Status="Sleeping"},
					new ContactData{Name="Sena", Status="Active"}
				},
				new ContactGroup("H1","H")
				{
					new ContactData{Name="Hanna", Status="Absent"}

				}
			};
		}
	}
}
