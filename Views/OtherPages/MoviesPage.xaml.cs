using ListBuddy.ViewModels;
namespace ListBuddy.Views.OtherPages;

public partial class MoviesPage : ContentPage
{
	public MoviesPage(MoviesPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}