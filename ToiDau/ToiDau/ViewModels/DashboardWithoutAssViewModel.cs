using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Prism.Navigation;
using ToiDau.Models;

namespace ToiDau.ViewModels
{
	public class DashboardWithoutAssViewModel : BindableBase, INavigationAware
    {
        private INavigationService _iNavigationService;
        private string SearchValue { get; set; }  
        public DelegateCommand SearchCommand { get; set; }
        public DelegateCommand<RecentPlace> ItemTappedCommand { get; set; }
        public ObservableCollection<RecentPlace> RecentPlaceList { get; set; }
        public DashboardWithoutAssViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            RecentPlaceList = new ObservableCollection<RecentPlace>
            {
                new RecentPlace
                {
                    Place = "Vincom Center",
                    Address = "72 Le Thanh Tong"
                },
                new RecentPlace
                {
                    Place = "Vincom Center",
                    Address = "72 Le Thanh Tong"
                },
                new RecentPlace
                {
                    Place = "Vincom Center",
                    Address = "72 Le Thanh Tong"
                }
            };
            SearchCommand = new DelegateCommand(SearchAction);
            ItemTappedCommand = new DelegateCommand<RecentPlace>(ItemTapped);

        }

        private void ItemTapped(RecentPlace rencentPlace)
        {
            var param = new NavigationParameters
            {
                { "recentPlace", rencentPlace }
            };
            _iNavigationService.NavigateAsync("DashboardPage", param, false, false);
        }

        private void SearchAction()
        {
            _iNavigationService.NavigateAsync("SearchPage", null, false, false);
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
