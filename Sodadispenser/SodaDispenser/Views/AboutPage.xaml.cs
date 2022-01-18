using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using SodaDispenser.Services;

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

        private void fris1check(object sender, EventArgs e)
        {
			string frisstatus = Arduino.CummunicateR("Fris1Status");
            if (frisstatus == "green")
            {
                fris1.BackgroundColor = Color.Green;
            }
            if (frisstatus == "red")
            {
                fris1.BackgroundColor = Color.Red;
            }
        }

        private void fris2check(object sender, EventArgs e)
        {
            string frisstatus = Arduino.CummunicateR("Fris2Status");
            if (frisstatus == "green")
            {
                fris2.BackgroundColor = Color.Green;
            }
            if (frisstatus == "red")
            {
                fris2.BackgroundColor = Color.Red;
            }
        }
    }
}