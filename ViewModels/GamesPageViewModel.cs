using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using ListBuddy.Views.OtherPages;
using System.Collections.ObjectModel;

namespace ListBuddy.ViewModels
{
    public partial class GamesPageViewModel : ObservableObject
    {
        public GamesPageViewModel()
        {
            items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(text))
                return;
            items.Add(text);
            text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if(items.Contains(s))
            {
                items.Remove(s);
            }
        }

        [RelayCommand]       
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(GamesDetailPage)}?Text={s}");               
        }
    }
}
