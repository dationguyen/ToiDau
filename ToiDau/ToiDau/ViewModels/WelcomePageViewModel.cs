using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Prism.Navigation;

namespace ToiDau.ViewModels
{
    public class WelcomePageViewModel : BindableBase, INavigatedAware
    {
        private INavigationService _iNavigationService;

        public DelegateCommand NavigateToLoginPage1Command { get; set; }

        public WelcomePageViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            NavigateToLoginPage1Command = new DelegateCommand(NavigateToLoginPage1);
        }

        public void NavigateToLoginPage1()
        {
            _iNavigationService.NavigateAsync("LoginPage1", null, false, false);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {
            
        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }
    }
}
