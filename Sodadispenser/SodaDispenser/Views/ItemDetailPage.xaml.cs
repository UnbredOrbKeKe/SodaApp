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
		public static Item item = ItemsPage._selectedItem;
		public ItemDetailPage()
		{

			InitializeComponent();
			BindingContext = new ItemDetailViewModel();

		}

		

        private async void letsMix(object sender, System.EventArgs e)
        {
            string counter = mixCode.Text;
            int[] shots = counter.Split('-').Select(Int32.Parse).ToArray();

            Arduino.Cummunicate("Pomp1");
            await Task.Delay(12000 * shots[0]);
            Arduino.Cummunicate("Pomp1");
            Arduino.Cummunicate("Pomp2");
            await Task.Delay(12000 * shots[1]);
            Arduino.Cummunicate("Pomp2");
            Arduino.Cummunicate("Pomp3");
            await Task.Delay(12000 * shots[2]);
            Arduino.Cummunicate("Pomp3");
            Arduino.Cummunicate("Pomp4");
            await Task.Delay(12000 * shots[3]);
            Arduino.Cummunicate("Pomp4");
            Arduino.Cummunicate("Pomp5");
            await Task.Delay(12000 * shots[4]);
            Arduino.Cummunicate("Pomp5");
            Arduino.Cummunicate("Pomp6");
            await Task.Delay(12000 * shots[5]);
            Arduino.Cummunicate("Pomp6");
            Arduino.Cummunicate("Pomp7");
            await Task.Delay(12000 * shots[6]);
            Arduino.Cummunicate("Pomp7");
            Arduino.Cummunicate("Pomp8");
            await Task.Delay(12000 * shots[7]);
            Arduino.Cummunicate("Pomp8");
         
            testje.Text = "Je mix is klaar maat";
        }
    }
}