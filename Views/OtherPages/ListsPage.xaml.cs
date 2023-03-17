using ListBuddy.ViewModels;

namespace ListBuddy.Views.OtherPages;

public partial class ListsPage : ContentPage
{
	public ListsPage(ListsPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}