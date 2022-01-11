using SodaDispenser.Models;
using SodaDispenser.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SodaDispenser.Views
{
	public partial class NewItemPage : ContentPage
	{
		public Item Item { get; set; }

		public NewItemPage()
		{
            InitializeComponent();

			Drink1.Text = "shots " + Preferences.Get("Drank1", "No Input");
			Drink2.Text = "shots " + Preferences.Get("Drank2", "No Input");
			Drink3.Text = "shots " + Preferences.Get("Drank3", "No Input");
			Drink4.Text = "shots " + Preferences.Get("Drank4", "No Input");
			Drink5.Text = "shots " + Preferences.Get("Drank5", "No Input");
			Drink6.Text = "shots " + Preferences.Get("Drank6", "No Input");
			Drink7.Text = "shots " + Preferences.Get("Drank7", "No Input");
			Drink8.Text = "shots " + Preferences.Get("Drank8", "No Input");

			BindingContext = new NewItemViewModel();
		}

        private void Slider(object sender, ValueChangedEventArgs e)
        {
			Preferences.Set("MixCode", Pump1.Text + "-" +
							  Pump2.Text + "-" +
							  Pump3.Text + "-" +
							  Pump4.Text + "-" +
							  Pump5.Text + "-" +
							  Pump6.Text + "-" +
							  Pump7.Text + "-" +
							  Pump8.Text);

			mixcode.Text = Preferences.Get("MixCode", string.Empty);
			save.IsVisible = false;
		}

        private void verify(object sender, EventArgs e)
        {
			int shotcount = Convert.ToInt32(pomp1.Value) + Convert.ToInt32(pomp2.Value) + Convert.ToInt32(pomp3.Value) + Convert.ToInt32(pomp4.Value) +
							Convert.ToInt32(pomp5.Value) + Convert.ToInt32(pomp6.Value) + Convert.ToInt32(pomp7.Value) + Convert.ToInt32(pomp8.Value);

			if (shotcount > 20)
            {
				DisplayAlert("Alert", "Je glas mag niet overstromen daab", "ok");
			}
            else
            {
				save.IsVisible = true;
            }
        }
    }
}