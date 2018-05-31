using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListViewContext
{
    public partial class MainPage : ContentPage
    {
        public List<Item> listItems = null;

        public MainPage()
        {
            InitializeComponent();

            listItems = new List<Item>();

            listItems.Add(new Item(){
                Title = "Item 1",
                Resource = "Id 1"
            });

            listItems.Add(new Item()
            {
                Title = "Item 2",
                Resource = "Id 2"
            });

            items.ItemsSource = listItems;
        }

        void Handle_ItemTapped(object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            Debug.WriteLine("Item of ListView tapped");
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Debug.WriteLine("Context MenuItem tapped");
        }
    }
}
