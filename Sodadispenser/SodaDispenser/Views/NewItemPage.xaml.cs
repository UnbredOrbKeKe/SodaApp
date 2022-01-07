using SodaDispenser.Models;
using SodaDispenser.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SodaDispenser.Views
{
	public partial class NewItemPage : ContentPage
	{
		public Item Item { get; set; }

		public NewItemPage()
		{
			InitializeComponent();
			BindingContext = new NewItemViewModel();
		}

        private void slider1(object sender, ValueChangedEventArgs e)
        {
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter1.Text = msg;
        }

		private void slider2(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter2.Text = msg;
		}

		private void slider3(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter3.Text = msg;
		}

		private void slider4(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter4.Text = msg;
		}

		private void slider5(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter5.Text = msg;
		}

		private void slider6(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter6.Text = msg;
		}

		private void slider7(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter7.Text = msg;
		}

		private void slider8(object sender, ValueChangedEventArgs e)
		{
			int val = Convert.ToInt32(e.NewValue);
			string msg = string.Format("{0} shots", val);
			this.shotCounter8.Text = msg;
		}
	}
}