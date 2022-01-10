using SodaDispenser.ViewModels;
using SodaDispenser.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace SodaDispenser
{
	public partial class AppShell : Xamarin.Forms.Shell
	{
		public AppShell()
		{
			InitializeComponent();
			Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
			Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
			Routing.RegisterRoute(nameof(Settings1), typeof(Settings1));
		}

	}
}
