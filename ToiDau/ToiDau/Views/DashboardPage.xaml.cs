using System;
using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
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
    }
}
