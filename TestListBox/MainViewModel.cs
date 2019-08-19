using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace TestListBox
{
	public class MainViewModel : BindableBase
	{
		public MainViewModel()
		{
			items = new ObservableCollection<Item>();
			items.Add(new Item("One"));
			items.Add(new Item("Two"));
			items.Add(new Item("Three"));
		}
		private ObservableCollection<Item> items;
		public ObservableCollection<Item> Items
		{
			get { return items; }
			set { SetProperty(ref items, value); }
		}
		private int selectedItemIndex;
		public int SelectedItemIndex
		{
			get { return selectedItemIndex; }
			set { SetProperty(ref selectedItemIndex, value); }
		}
	}
}
