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
        public DelegateCommand FacebookCommand { get; set; }
        public DelegateCommand TwitterCommand { get; set; }
        public DelegateCommand NotificationCommand { get; set; }      
        public PromotionsPageViewModel()
        {
            FacebookCommand = new DelegateCommand(OnFacebookCommandExecuted);
            TwitterCommand = new DelegateCommand(OnTwitterCommandExecuted);
            NotificationCommand = new DelegateCommand(OnNotificationCommandExecuted);
        }

        private void OnNotificationCommandExecuted()
        {
            //Do something
        }

        private void OnTwitterCommandExecuted()
        {
            Device.OpenUri(new Uri("https://www.google.com.vn/"));
        }

        private void OnFacebookCommandExecuted()
        {
            Device.OpenUri(new Uri("https://www.google.com.vn/"));
        }
    }
}
