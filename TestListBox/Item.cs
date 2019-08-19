using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;

namespace TestListBox
{
	public class Item : BindableBase
	{
		public Item(string name)
		{
			this.name = name;
			this.description = "";
		}
		private string name;
		public string Name
		{
			get { return name; }
			set { SetProperty(ref name, value); }
		}
		private string description;
		public string Description
		{
			get { return description; }
			set { SetProperty(ref description, value); }
		}
	}
}
