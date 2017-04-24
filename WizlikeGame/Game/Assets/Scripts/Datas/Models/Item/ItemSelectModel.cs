using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;
using Data.Model;
using System.Linq;

public class ItemSelectModel
{
	Dictionary<ItemMaster, int> Items = new Dictionary<ItemMaster, int>();

	int price;
	public int Price { get { return price; } }
	public bool CanBuy { get { return price <= GameModel.Instance.Models.Player.Player.Money; } }

	public int GetItemCount(ItemMaster master)
	{
		return Items[master];
	}

	public void Add(ItemMaster master, int count)
	{
		if (Items.ContainsKey(master))
		{
			Items[master] = count;
		}
		else
		{
			Items.Add(master, count);
		}
		Calculate();
	}

	public void Remove(ItemMaster master)
	{
		Items.Remove(master);
		Calculate();
	}

	public void Calculate()
	{
		price = Items.Select((item, index) => ItemPrice(item)).Sum();
	}

	int ItemPrice(KeyValuePair<ItemMaster, int> keyValue)
	{
		return keyValue.Key.price * keyValue.Value;
	}

	public void Sell()
	{
		Items.ForEach((item, index) => GameModel.Instance.Models.Item.Remove(item.Key.id));
		GameModel.Instance.Models.Player.Player.AddMoney(Price);
		Clear();
	}

	public void Buy()
	{
		Items.ForEach((item, index) => GameModel.Instance.Models.Item.Add(Item.Create(item.Key, true)));
		GameModel.Instance.Models.Player.Player.DelMoney(Price);
		Clear();
	}

	void Clear()
	{
		Items.Clear();
	}
}
