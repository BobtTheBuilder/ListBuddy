﻿using ListBuddy.ViewModels;
using ListBuddy.Views.Dashboard;
using ListBuddy.Views.OtherPages;

namespace ListBuddy;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		this.BindingContext = new AppShellViewModel();
		Routing.RegisterRoute(nameof(HomePage), typeof(HomePage));
		Routing.RegisterRoute(nameof(GamesDetailPage),typeof(GamesDetailPage));
	}
}
