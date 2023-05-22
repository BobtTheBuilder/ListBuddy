using ListBuddy.ViewModels;

namespace ListBuddy.Views.OtherPages;

public partial class GamesDetailPage : ContentPage
{
	public GamesDetailPage(GamesDetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}