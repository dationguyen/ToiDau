using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToiDau.ViewModels
{
    public class MainPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _iNavigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
        private async void NavigationToWelcomePage()
        {
            await Task.Delay(2000);
            this._iNavigationService.NavigateAsync("WelcomePage", null, false, false);
        }
        public void OnNavigatedTo(NavigationParameters parameters)
        {
            NavigationToWelcomePage();
        }
    }
}
