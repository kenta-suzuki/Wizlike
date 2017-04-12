using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

namespace Data.Model
{
	public class ItemModel
	{
		const string key = "item";
		public List<Item> Items;
		public bool HasItemData { get { return PlayerPrefs.HasKey(key); } }

		public void Initialize()
		{
			Items = new List<Item>();
			if (HasItemData)
			{
				Load();
			}
		}

		void Clear()
		{
			Items.Clear();
		}

		public void Load()
		{
			Clear();
			JSONObjectExtension.ToStringList(PlayerPrefs.GetString(key)).ForEach(i => Add(Item.Create(i)));
		}

		public void CreateNewData()
		{
			var item = Item.Create(GameModel.Instance.Masters.Item.Datas.First(e => e.id == 1));
			Add(item);
		}

		public void Add(Item item)
		{
			Items.Add(item);
		}

		public void Remove(Item item)
		{
			Items.Remove(item);
		}

		public void Save()
		{
			PlayerPrefs.SetString(key, Items.Select(e => e.ToString()).ToList().ToJsonString());
		}
	}
}