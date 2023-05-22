using ListBuddy.ViewModels;
namespace ListBuddy.Views.OtherPages;

public partial class DailyTasks : ContentPage
{
	public DailyTasks(DailyTasksPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}