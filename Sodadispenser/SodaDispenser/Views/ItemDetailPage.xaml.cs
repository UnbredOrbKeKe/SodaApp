using SodaDispenser.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace SodaDispenser.Views
{
	public partial class ItemDetailPage : ContentPage
	{
		public ItemDetailPage()
		{
			InitializeComponent();
			BindingContext = new ItemDetailViewModel();
		}

		private void DeleteButton(object sender, System.EventArgs e)
		{
		}
	}
}