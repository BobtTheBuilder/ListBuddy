using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListBuddy.Controls;
using ListBuddy.Models;
using ListBuddy.Views.Dashboard;
using ListBuddy.Views.OtherPages;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBuddy.ViewModels.Startup
{
    public partial class LoginPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        private string _email;

        [ObservableProperty] 
        private string _password;

        #region Commands
        [RelayCommand]
        async void Login()
        {
            if(!string.IsNullOrEmpty(Email)&& !string.IsNullOrEmpty(Password))
            {

                var userDetails = new UserInfo()
                {
                    Email = Email,
                    FullName= "Test Username"
                };


                if(Preferences.ContainsKey(nameof(App.UserDetails)))
                {
                    Preferences.Remove(nameof(App.UserDetails));    
                }

                string userDetailStr = JsonConvert.SerializeObject(userDetails);
                Preferences.Set(nameof(App.UserDetails), userDetailStr);
                App.UserDetails = userDetails;
                AppShell.Current.FlyoutHeader = new FlyoutHeaderControl();

                await Shell.Current.GoToAsync($"//{nameof(HomePage)}");
            }
                
        }
        #endregion
    }
}
