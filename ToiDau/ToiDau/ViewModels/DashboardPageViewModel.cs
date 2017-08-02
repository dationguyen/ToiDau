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
        public string SearchValue { get; set; }
        public DelegateCommand SearchCommand { get; set; }
        public DelegateCommand NotificationCommand { get; set; }
        public DashboardPageViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            SearchCommand = new DelegateCommand(SearchAction);
            NotificationCommand = new DelegateCommand(OnNotificationCommandExecuted);
        }

        private void OnNotificationCommandExecuted()
        {
            //Do something
        }
        private void SearchAction()
        {
            var param = new NavigationParameters { { "searchValue", SearchValue } };
            _iNavigationService.NavigateAsync("SearchPage", param, false, false);
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
