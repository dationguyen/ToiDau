using Prism.Unity;
using ToiDau.Views;
using Xamarin.Forms;

namespace ToiDau
{
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) { }

        protected override void OnInitialized()
        {
            InitializeComponent();

            NavigationService.NavigateAsync("NavigationPage/MainPage");
        }

        protected override void RegisterTypes()
        {
            Container.RegisterTypeForNavigation<NavigationPage>();
            Container.RegisterTypeForNavigation<MainPage>();
            Container.RegisterTypeForNavigation<WelcomePage>("WelcomePage");
            Container.RegisterTypeForNavigation<LoginPage1>("LoginPage1");
            Container.RegisterTypeForNavigation<LoginPage2>("LoginPage2");
            Container.RegisterTypeForNavigation<LoginPage3>("LoginPage3");
        }
    }
}
