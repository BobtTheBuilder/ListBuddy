using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Kotlin;

namespace ListBuddy.ViewModels;

[QueryProperty("Text", "Text")]
public partial class DetailPageViewModel : ObservableObject
{
    [ObservableProperty]
    string text;

    [RelayCommand]
    async Task GoBackHome()
    {
        await Shell.Current.GoToAsync("HomePage");
    }

    [RelayCommand]
    async Task GoBack()
    {
        await Shell.Current.GoToAsync("..");
    }
}

