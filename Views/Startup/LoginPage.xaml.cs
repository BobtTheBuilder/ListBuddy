using ListBuddy.ViewModels.Startup;

namespace ListBuddy.Views.Startup;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}
} 