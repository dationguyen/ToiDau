using Xamarin.Forms;

namespace ToiDau.Views
{
    public partial class MyMasterDetailPage : MasterDetailPage
    {
        public MyMasterDetailPage()
        {
            InitializeComponent();
            switch (Device.RuntimePlatform)
            {
                case Device.Android:
                    NavigationPage.Icon = "hamburger.png";
                    break;
                case Device.Windows:
                    NavigationPage.Icon = "Assets/Images/hamburger.png";
                    break;
                case Device.iOS:
                    NavigationPage.Icon = "Images/hamburger.png";
                    break;
            }
        }
    }
}