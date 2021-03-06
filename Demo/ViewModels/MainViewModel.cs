﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using PropertyChanged;

namespace Demo
{
	[ImplementPropertyChanged]
	public class MainViewModel
	{
		public MainViewModel()
		{
			Position = 0;
			ItemsSource = new ObservableCollection<int>() { 0 };
			TemplateSelector = new MyTemplateSelector(); //new DataTemplate (typeof(MyView));
		}

		public int Position { get; set; }

		public ObservableCollection<int> ItemsSource { get; set; }

		public MyTemplateSelector TemplateSelector { get; set; }
	}
}
