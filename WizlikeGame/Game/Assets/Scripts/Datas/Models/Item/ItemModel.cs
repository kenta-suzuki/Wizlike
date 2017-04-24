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
		public List<Equipment> Equipments { get { return GameModel.Instance.Models.Equipment.Equipments; } }
		public List<IItem> AllItems { get { return Items.Cast<IItem>().Intersect(Equipments.Cast<IItem>()).ToList(); }}
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

		public void CreateNewData(bool isAppraisal)
		{
			var item = Item.Create(GameModel.Instance.Masters.Item.Datas.First(e => e.id == 1), isAppraisal);
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

		public void Remove(int id)
		{
			var item = Items.FirstOrDefault(i => i.Id == id);
			var equipment = Equipments.FirstOrDefault(e => e.Id == id);
			if (item == null && equipment == null) return;

			if (item != null)
			{
				Items.Remove(item);

			}
			else if (equipment != null)
			{
				Equipments.Remove(equipment);
			}
		}

		public void Save()
		{
			PlayerPrefs.SetString(key, Items.Select(e => e.ToString()).ToList().ToJsonString());
		}
	}
}