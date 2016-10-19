﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewExample.Xaml
{
    public partial class ListViewImageCell : ContentPage
    {
        public ListViewImageCell()
        {
            InitializeComponent();

            BindingContext = new ListViewImageCellViewModel();
        }

        async void ListViewItemTapped(object sender, ItemTappedEventArgs e)
        {
            ListItem item = (ListItem)e.Item;
            await DisplayAlert("Tapped", item.Title + " was selected.", "OK");
            ((ListView)sender).SelectedItem = null;
        }

        public class ListViewImageCellViewModel : BindableObject
        {
            List<ListItem> listItems;
            public List<ListItem> ListItems
            {
                get
                {
                    return listItems;
                }
                set
                {
                    listItems = value;
                    OnPropertyChanged("ListItems");
                }
            }

            public ListViewImageCellViewModel()
            {
                ListItems = new List<ListItem> { 
                    new ListItem {Source = "first.png", Title = "First", Description="1st item"}, 
                    new ListItem {Source = "second.png", Title = "Second", Description="2nd item"},
                    new ListItem {Source = "third.png", Title = "Third", Description="3rd item"}
                };
            }
        }

        public class ListItem
        {
            public string Source { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
        }

    }


}

