using ListBuddy.ViewModels.Dashboard;

namespace ListBuddy.Views.Dashboard;

public partial class DashboardPage : ContentPage
{
	public DashboardPage(DashboardPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}
}