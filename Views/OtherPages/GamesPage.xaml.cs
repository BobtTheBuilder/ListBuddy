using ListBuddy.ViewModels;
namespace ListBuddy.Views.OtherPages;

public partial class GamesPage : ContentPage
{
	public GamesPage(GamesPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}