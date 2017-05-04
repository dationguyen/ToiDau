using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToiDau.ViewModels
{
    public class DashboardPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _iNavigationService;
        public DelegateCommand NotificationCommand { get; set; }
        public DashboardPageViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            NotificationCommand = new DelegateCommand(OnNotificationCommandExecuted);
        }

        private void OnNotificationCommandExecuted()
        {
            //Do something
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
