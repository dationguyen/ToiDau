using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ToiDau.ViewModels
{
    public class ProfilePageViewModel : BindableBase
    {
        private string _facebookLink;

        public string FacebookLink
        {
            get {return _facebookLink; }
            set { SetProperty(ref _facebookLink, value); }
        }
        private string _twitterLink;

        public string TwitterLink
        {
            get { return _twitterLink; }
            set { SetProperty(ref _twitterLink, value); }
        }
        public DelegateCommand<string> NavigationToSocialAccountCommand { get; set; }
        public ProfilePageViewModel()
        {
            NavigationToSocialAccountCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
        }

        private void OnNavigateCommandExecuted(string link)
        {          
            Device.OpenUri(new Uri(link));
        }
    }
}
