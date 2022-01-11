using SodaDispenser.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;
using SodaDispenser.Services;
using SodaDispenser.Models;
using System.Threading.Tasks;
using System;
using System.Linq;


namespace SodaDispenser.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public Item _selectedItem;
		

		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();

		}
		public Item SelectedItem
		{
			get => _selectedItem;
		}
		private void DeleteButton(object sender, EventArgs e)
		{

			var item = (ToolbarItem)sender;
			Item listitem = (from itm in MockDataStore.items
							 where itm.Text == item.CommandParameter.ToString()
							 select itm)
							.FirstOrDefault<Item>();
			MockDataStore.items.Remove(listitem);

			Navigation.PopAsync();

		}

	}
}