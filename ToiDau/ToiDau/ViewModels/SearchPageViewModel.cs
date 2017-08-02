using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Prism.Navigation;
using ToiDau.Models;

namespace ToiDau.ViewModels
{
    public class SearchPageViewModel : BindableBase, INavigationAware
    {
        private INavigationService _iNavigationService;
        private string SearchValue { get; set; }
        public ObservableCollection<SearchResult> SearchResultList { get; set; }
        public DelegateCommand<SearchResult> ItemTappedCommand { get; set; }
        public SearchPageViewModel(INavigationService navigationService)
        {
            _iNavigationService = navigationService;
            ItemTappedCommand = new DelegateCommand<SearchResult>(ItemTapped);
            SearchResultList = new ObservableCollection<SearchResult>
            {
                new SearchResult
                {
                    Address = "Vincom Center",
                    Note1 = "1.2 km from your curent location",
                    Note2 = "20 mins driving without trafic",
                    Distance = 1.5
                },
                new SearchResult
                {
                    Address = "Vincom Center",
                    Note1 = "1.2 km from your curent location",
                    Note2 = "20 mins driving without trafic",
                    Distance = 1.8
                },
                new SearchResult
                {
                    Address = "Vincom Center",
                    Note1 = "1.2 km from your curent location",
                    Note2 = "20 mins driving without trafic",
                    Distance = 2.5
                },
                new SearchResult
                {
                    Address = "Vincom Center",
                    Note1 = "1.2 km from your curent location",
                    Note2 = "20 mins driving without trafic",
                    Distance = 4.5,
                    IsLast = true
                }
            };
        }

        private void ItemTapped(SearchResult itemSelected)
        {
            var param = new NavigationParameters
            {
                { "itemSelected", itemSelected }
            };
            _iNavigationService.NavigateAsync("DashboardPage", param, false, false);
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
