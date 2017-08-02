using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToiDau.ViewModels
{
    public class LoginPage3ViewModel : BindableBase, INavigationAware
    {
        private INavigationService _iNavigationService;
        public DelegateCommand NavigateToDashboardCommand { get; set; }
        public LoginPage3ViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            NavigateToDashboardCommand = new DelegateCommand(NavigateToDashboard);
        }

        private void NavigateToDashboard()
        {
            _iNavigationService.NavigateAsync("/MyMasterDetailPage/NavigationPage/DashboardWithoutAss", null, false, false);
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
