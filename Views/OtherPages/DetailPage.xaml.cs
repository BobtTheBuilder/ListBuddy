using ListBuddy.ViewModels;

namespace ListBuddy.Views.OtherPages;

public partial class DetailPage : ContentPage
{
	public DetailPage(DetailPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}