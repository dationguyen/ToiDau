using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ToiDau.ViewModels
{
    public class MyMasterDetailPageViewModel : BindableBase, INavigationAware
    {
        INavigationService _iNavigationService;
        public DelegateCommand<string> NavigateCommand { get; set; }
        public MyMasterDetailPageViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            NavigateCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        private async void OnNavigateCommandExecuted(string path)
        {
            await _iNavigationService.NavigateAsync(path, null, false, false);
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
