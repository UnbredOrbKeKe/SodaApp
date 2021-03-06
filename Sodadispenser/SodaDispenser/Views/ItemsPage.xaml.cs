using SodaDispenser.Models;
using SodaDispenser.ViewModels;
using SodaDispenser.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SodaDispenser.Services;

namespace SodaDispenser.Views
{
	public partial class ItemsPage : ContentPage
	{
		ItemsViewModel _viewModel;

		public ItemsPage()
		{
			InitializeComponent();

			BindingContext = _viewModel = new ItemsViewModel();
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModel.OnAppearing();
		}

		private void OnDelete(object sender, EventArgs e)
		{
			MockDataStore.items
		}
	}
}