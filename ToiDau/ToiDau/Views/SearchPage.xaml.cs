using System.Collections.Generic;
using System.Linq;
using ToiDau.Models;
using ToiDau.ViewModels;
using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class SearchPage : ContentPage
    {
        public SearchPage()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    ToolbarItem.Icon = "notification.png";
                    break;
                case Device.iOS:
                    ToolbarItem.Icon = "Images/notification.png";
                    break;
                case Device.Windows:
                    ToolbarItem.Icon = "Assets/Images/notification.png";
                    break;
            }
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            ((SearchPageViewModel)BindingContext).ItemTappedCommand.Execute((SearchResult)e.Item);
            ((ListView)sender).SelectedItem = null;
        }
    }
}
