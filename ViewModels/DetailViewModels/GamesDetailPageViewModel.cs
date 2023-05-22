using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace ListBuddy.ViewModels;

[QueryProperty("Text", "Text")]
public partial class GamesDetailPageViewModel : ObservableObject
{
    public GamesDetailPageViewModel()
    {
        gameitem = new ObservableCollection<string>();
    }
    [ObservableProperty]
    ObservableCollection<string> gameitem;
    [ObservableProperty]
    string text;

    [ObservableProperty]
    string gametext;
   
    [RelayCommand]
     void Add()
    {
        if (string.IsNullOrWhiteSpace(gametext))
            return;

        gameitem.Add(gametext);
        gametext = string.Empty;
    }

    [RelayCommand]
     void Delete(string s)
    {
        if (gameitem.Contains(s))
        {
            gameitem.Remove(s);
        }
    }
}



