using ListBuddy.Controls;
using ListBuddy.Models;
using ListBuddy.Views.Dashboard;
using ListBuddy.Views.OtherPages;
using ListBuddy.Views.Startup;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBuddy.ViewModels.Startup
{
    public class LoadingPageViewModel
    {
        public LoadingPageViewModel()
        {
            CheckUserLoginDetails();
        }
        private async void CheckUserLoginDetails()
        {
            string userDetailsStr = Preferences.Get(nameof(App.UserDetails), "");

            if (string.IsNullOrEmpty(userDetailsStr))
            {
                await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
            }
            else 
            {
                var userInfo = JsonConvert.DeserializeObject<UserInfo>(userDetailsStr);
                App.UserDetails = userInfo;
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();
                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
        }
    }
}
