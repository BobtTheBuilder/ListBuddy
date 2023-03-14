using CommunityToolkit.Mvvm.Input;
using ListBuddy.Views.Startup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBuddy.ViewModels
{
    public partial class AppShellViewModel : BaseViewModel
    {
        [RelayCommand]

        async void SignOut()
        {
            if (Preferences.ContainsKey(nameof(App.UserDetails)))
            {
                Preferences.Remove(nameof(App.UserDetails));    
            }
            await Shell.Current.GoToAsync($"//{nameof(LoginPage)}");
        }
    }
}
