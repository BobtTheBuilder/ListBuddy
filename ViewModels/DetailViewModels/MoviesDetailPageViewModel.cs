using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ListBuddy.ViewModels;

[QueryProperty("Text", "Text")]
public partial class MoviesDetailPageViewModel : ObservableObject
{
    public MoviesDetailPageViewModel()
    {
        movieitem = new ObservableCollection<string>();
    }
    [ObservableProperty]
    ObservableCollection<string> movieitem;
    [ObservableProperty]
    string text;

    [ObservableProperty]
    string movietext;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrWhiteSpace(movietext))
            return;

        movieitem.Add(movietext);
        movietext = string.Empty;
    }

    [RelayCommand]
    void Delete(string s)
    {
        if (movieitem.Contains(s))
        {
            movieitem.Remove(s);
        }
    }
}
