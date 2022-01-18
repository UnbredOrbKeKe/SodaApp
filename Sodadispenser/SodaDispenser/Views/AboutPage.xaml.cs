using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace SodaDispenser.Views
{
	public partial class AboutPage : ContentPage
	{
		public AboutPage()
		{
			InitializeComponent();
			fris1.Text = Preferences.Get("Drank1", string.Empty);
			fris2.Text = Preferences.Get("Drank2", string.Empty);
		}
	}
}