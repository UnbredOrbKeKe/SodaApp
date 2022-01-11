using SodaDispenser.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using SodaDispenser.Services;
using SodaDispenser.Models;
using System.Threading.Tasks;
using System;


namespace SodaDispenser.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public static Item item = ItemsPage._selectedItem;
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();

		}

		private void DeleteButton(object sender, System.EventArgs e)
		{
			MockDataStore.items.Remove(item);
			
		}

	}
}