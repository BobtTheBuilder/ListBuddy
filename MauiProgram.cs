using ListBuddy.ViewModels;
using ListBuddy.ViewModels.Dashboard;
using ListBuddy.ViewModels.Startup;
using ListBuddy.Views;
using ListBuddy.Views.Dashboard;
using ListBuddy.Views.DetailPages;
using ListBuddy.Views.OtherPages;
using ListBuddy.Views.Startup;

namespace ListBuddy;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<DashboardPage>();
		builder.Services.AddSingleton<LoginPage>();
		builder.Services.AddSingleton<LoadingPage>();
		builder.Services.AddSingleton<GamesPage>();
		builder.Services.AddTransient<GamesDetailPage>();
		builder.Services.AddTransient<MoviesPage>();
		builder.Services.AddTransient<DailyTasks>();
		builder.Services.AddTransient<MoviesDetailPage>();

		builder.Services.AddTransient<MoviesDetailPageViewModel>();
		builder.Services.AddTransient<DailyTasksPageViewModel>();
		builder.Services.AddTransient<MoviesPageViewModel>();
		builder.Services.AddTransient<GamesDetailPageViewModel>();
        builder.Services.AddSingleton<LoginPageViewModel>();
		builder.Services.AddSingleton<DashboardPageViewModel>();
		builder.Services.AddSingleton<LoadingPageViewModel>();
		builder.Services.AddSingleton<GamesPageViewModel>();

        return builder.Build();
	}
}
