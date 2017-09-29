using System;
using System.Collections.Generic;

namespace DemoListEx
{
	class ContactGroup : List<ContactData>
	{
		public string Title { get; set; }
		public string ShortTitle { get; set; }

		public ContactGroup(string title, string shorttitle)
		{
			Title = title;
			ShortTitle = shorttitle;
		}
	}
}
