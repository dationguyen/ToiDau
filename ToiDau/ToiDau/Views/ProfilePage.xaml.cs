using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class ProfilePage : ContentPage
    {
        public ProfilePage()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    ToolbarItem.Icon = "notification.png";
                    Facebook.Image = "fb_icon.png";
                    Facebook.Scale = 0.5;
                    Twitter.Scale = 0.5;
                    Twitter.Image = "tw_icon.png";
                    break;
                case Device.Windows:
                    ToolbarItem.Icon = "Assets/Images/notification.png";
                    Facebook.Image = "Assets/Images/fb_icon.png";
                    Facebook.Scale = 0.5;
                    Twitter.Scale = 0.5;
                    Twitter.Image = "Assets/Images/tw_icon.png";                
                    break;
                case Device.iOS:
                    ToolbarItem.Icon = "Images/notification.png";
                    Facebook.Image = "Images/fb_icon.png";
                    Facebook.Scale = 0.5;
                    Twitter.Scale = 0.5;
                    Twitter.Image = "Images/tw_icon.png";
                    break;
            }
        }
    }
}
