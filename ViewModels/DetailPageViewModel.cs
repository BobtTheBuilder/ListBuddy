using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace ListBuddy.ViewModels;

[QueryProperty("Text", "Text")]
public partial class DetailPageViewModel : ObservableObject
{
    public DetailPageViewModel()
    {
        Gameitems = new ObservableCollection<string>();
    }

    
    public ObservableCollection<string> Gameitems { get; set; }

    
    public string Text { get; set; }

    
    public string Gametext { get; set; }

    [RelayCommand]
    public void Add()
    {
        if (string.IsNullOrWhiteSpace(Gametext))
            return;

        Gameitems.Add(Gametext);
        Gametext = string.Empty;
    }

    [RelayCommand]
    public void Delete(string s)
    {
        if (Gameitems.Contains(s))
        {
            Gameitems.Remove(s);
        }
    }
}



