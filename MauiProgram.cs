﻿using ListBuddy.ViewModels;
using ListBuddy.ViewModels.Dashboard;
using ListBuddy.ViewModels.Startup;
using ListBuddy.Views;
using ListBuddy.Views.Dashboard;
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
		builder.Services.AddSingleton<ListsPage>();
		builder.Services.AddTransient<DetailPage>();

		builder.Services.AddTransient<DetailPageViewModel>();
        builder.Services.AddSingleton<LoginPageViewModel>();
		builder.Services.AddSingleton<DashboardPageViewModel>();
		builder.Services.AddSingleton<LoadingPageViewModel>();
		builder.Services.AddSingleton<ListsPageViewModel>();

        return builder.Build();
	}
}
