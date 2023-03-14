using ListBuddy.Models;

namespace ListBuddy;

public partial class App : Application
{
	public static UserInfo UserDetails;
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
