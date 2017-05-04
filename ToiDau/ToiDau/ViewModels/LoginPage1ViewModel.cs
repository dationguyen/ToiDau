using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToiDau.ViewModels
{
    public class LoginPage1ViewModel : BindableBase, INavigationAware
    {
        private INavigationService _iNavigationService;
        public DelegateCommand NavigateToLoginPage2Command { get; set; }
        private string _number = "";
        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }
        public LoginPage1ViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            NavigateToLoginPage2Command = new DelegateCommand(NavigateToLoginPage2);
        }

        private void NavigateToLoginPage2()
        {
            var param = new NavigationParameters();
            param.Add("number", Number);
            _iNavigationService.NavigateAsync("LoginPage2", param, false, false);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {

        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {

        }
    }
}
