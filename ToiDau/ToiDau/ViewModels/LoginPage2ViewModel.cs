using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToiDau.ViewModels
{
    public class LoginPage2ViewModel : BindableBase, INavigationAware
    {
        private INavigationService _iNavigationService;
        public DelegateCommand NavigateToLoginPage3Command { get; set; }
        private string _number = "";
        public string Number
        {
            get { return _number; }
            set { SetProperty(ref _number, value); }
        }

        public LoginPage2ViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            NavigateToLoginPage3Command = new DelegateCommand(NavigateToLoginPage3);
        }

        private void NavigateToLoginPage3()
        {
            _iNavigationService.NavigateAsync("LoginPage3", null, false, false);
        }

        public void OnNavigatedFrom(NavigationParameters parameters)
        {

        }

        public void OnNavigatedTo(NavigationParameters parameters)
        {
            if (parameters.ContainsKey("number"))
                Number = (string)parameters["number"];
        }

        public void OnNavigatingTo(NavigationParameters parameters)
        {
            
        }
    }
}
