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
		public static string MixCode;
		public Item Item { get; set; }

		public NewItemPage()
		{
			Drank1.Text = Preferences.Get("Drank1", string.Empty);
			InitializeComponent();
			
			MixCode = Convert.ToString(Drank1.Value) + ";" +
					  Convert.ToString(Drank2.Value) + ";" +
					  Convert.ToString(Drank3.Value) + ";" +
					  Convert.ToString(Drank4.Value) + ";" +
					  Convert.ToString(Drank5.Value) + ";" +
					  Convert.ToString(Drank6.Value) + ";" +
					  Convert.ToString(Drank7.Value) + ";" +
					  Convert.ToString(Drank8.Value);

			BindingContext = new NewItemViewModel();
		}

		


	}
}