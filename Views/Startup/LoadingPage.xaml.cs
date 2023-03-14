using ListBuddy.ViewModels.Startup;

namespace ListBuddy.Views.Startup;

public partial class LoadingPage : ContentPage
{
	public LoadingPage(LoadingPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}
}