﻿using SodaDispenser.Services;
using SodaDispenser.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SodaDispenser.Models;
using SodaDispenser.ViewModels;
using System.IO;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SodaDispenser
{
	public partial class App : Application
	{
		
		public App()
		{
			InitializeComponent();

			DependencyService.Register<MockDataStore>();
			MainPage = new AppShell();
		}

		protected  override void OnStart()
		{
			
        }

        protected override void OnSleep()
		{

		}

		protected override void OnResume()
		{
		}

		
	}
}
