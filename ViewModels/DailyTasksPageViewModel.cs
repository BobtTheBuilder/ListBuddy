using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ListBuddy.ViewModels
{
    public partial class DailyTasksPageViewModel : ObservableObject
    {
        public DailyTasksPageViewModel()
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
            if (items.Contains(s))
            {
                items.Remove(s);
            }
        }
    }
}
