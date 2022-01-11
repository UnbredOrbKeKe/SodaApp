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
		}
    }
}