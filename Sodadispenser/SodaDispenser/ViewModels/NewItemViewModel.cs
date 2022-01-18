﻿using SodaDispenser.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Essentials;
using SodaDispenser.Views;
using Json;
using Newtonsoft.Json;

namespace SodaDispenser.ViewModels
{
	public class NewItemViewModel : BaseViewModel
	{
		private string text;
		private string description;
		private string mixCode;

		public NewItemViewModel()
		{
			SaveCommand = new Command(OnSave, ValidateSave);
			CancelCommand = new Command(OnCancel);
			this.PropertyChanged +=
				(_, __) => SaveCommand.ChangeCanExecute();
		}

		private bool ValidateSave()
		{
			return !String.IsNullOrWhiteSpace(text)
				&& !String.IsNullOrWhiteSpace(description);
		}

		public string Text
		{
			get => text;
			set => SetProperty(ref text, value);
		}

		public string Description
		{
			get => description;
			set => SetProperty(ref description, value);
		}

		public string MixCode
        {
			get => mixCode;
			set => SetProperty(ref mixCode, value);
        }

				public Command SaveCommand { get; }
		public Command CancelCommand { get; }

		private async void OnCancel()
		{
			// This will pop the current page off the navigation stack
			await Shell.Current.GoToAsync("..");
		}

		private async void OnSave()
		{
			var newItem = new Item
			{
				Id = Guid.NewGuid().ToString(),
				Text = Text,
				Description = Description,
				MixCode = MixCode
			};

			var Cocktail = JsonConvert.SerializeObject(newItem);

			Application.Current.Properties.Add(newItem.Id, Cocktail);
			await Application.Current.SavePropertiesAsync();
			await DataStore.AddItemAsync(newItem);
			
			// This will pop the current page off the navigation stack
			await Shell.Current.GoToAsync("..");
		}
	}
}
