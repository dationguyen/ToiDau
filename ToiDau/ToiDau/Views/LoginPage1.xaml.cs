using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class LoginPage1 : ContentPage
    {
        public LoginPage1()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    this.BackgroundImage = "BackgroundLoginPage.png";
                    break;
                case Device.Windows:
                    this.BackgroundImage = "Assets/Images/BackgroundLoginPage.png";
                    break;
                case Device.iOS:
                    this.BackgroundImage = "Images/BackgroundLoginPage.png";
                    break;
            }
        }
    }
}
