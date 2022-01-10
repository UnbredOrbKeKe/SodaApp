﻿using SodaDispenser.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SodaDispenser.Services
{
	public class MockDataStore : IDataStore<Item>
	{
		public static List<Item> items;

		public MockDataStore()
		{
			items = new List<Item>()
			{
				new Item { Id = Guid.NewGuid().ToString(), Text = "Berenburg Cola", Description="This is an item description." },
				new Item { Id = Guid.NewGuid().ToString(), Text = "Raketje", Description="This is an item description." },
				new Item { Id = Guid.NewGuid().ToString(), Text = "Jagerbom", Description="This is an item description." },
				new Item { Id = Guid.NewGuid().ToString(), Text = "Fourth item", Description="This is an item description." },
				new Item { Id = Guid.NewGuid().ToString(), Text = "Fifth item", Description="This is an item description." },
				new Item { Id = Guid.NewGuid().ToString(), Text = "Sixth item", Description="This is an item description." }
			};
		}

		public async Task<bool> AddItemAsync(Item item)
		{
			items.Add(item);

			return await Task.FromResult(true);
		}

		public async Task<bool> UpdateItemAsync(Item item)
		{
			var oldItem = items.Where((Item arg) => arg.Id == item.Id).FirstOrDefault();
			items.Remove(oldItem);
			items.Add(item);

			return await Task.FromResult(true);
		}

		public async Task<bool> DeleteItemAsync(string id)
		{
			var oldItem = items.Where((Item arg) => arg.Id == id).FirstOrDefault();
			items.Remove(oldItem);

			return await Task.FromResult(true);
		}

		public async Task<Item> GetItemAsync(string id)
		{
			return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
		}

		public async Task<IEnumerable<Item>> GetItemsAsync(bool forceRefresh = false)
		{
			return await Task.FromResult(items);
		}
	}
}