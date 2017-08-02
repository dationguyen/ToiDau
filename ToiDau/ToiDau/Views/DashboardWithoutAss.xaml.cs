using ToiDau.Models;
using ToiDau.ViewModels;
using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class DashboardWithoutAss : ContentPage
    {
        public DashboardWithoutAss()
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
        public void ItemTapped (object sender, ItemTappedEventArgs args)
        {
            ((DashboardWithoutAssViewModel)BindingContext).ItemTappedCommand.Execute((RecentPlace)args.Item);
            ((ListView) sender).SelectedItem = null;
        }
        
    }
}
