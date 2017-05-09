using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;

namespace ToiDau.ViewModels
{
    public class PromotionsPageViewModel : BindableBase
    {
        public DelegateCommand<string> NavigationToSocialAccountCommand { get; set; }
        public DelegateCommand NotificationCommand { get; set; }      
        public PromotionsPageViewModel()
        {
            NavigationToSocialAccountCommand = new DelegateCommand<string>(OnNavigateCommandExecuted);
            NotificationCommand = new DelegateCommand(OnNotificationCommandExecuted);
        }

        private void OnNavigateCommandExecuted(string link)
        {
            Device.OpenUri(new Uri(link));
        }

        private void OnNotificationCommandExecuted()
        {
            //Do something
        }      
    }
}
