using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;
using Data.Model;

public class DangeonPlayer : MonoBehaviour
{
	ItemModel itemModel;
	public List<Item> Items { get { return itemModel.Items; } }
	EquipmentModel equipmentModel;

	public void Initialize()
	{
		itemModel = GameModel.Instance.Models.Item;
		equipmentModel = GameModel.Instance.Models.Equipment;
	}

	public void ReciveItem(int id)
	{
		if (id == -1) return;

		var itemMaster = GameModel.Instance.Masters.Item.Datas.FirstOrDefault(i => i.id == id);

		if (itemMaster != null)
		{
			itemModel.Add(Item.Create(itemMaster, false));
		}

		var equipmentMaster = GameModel.Instance.Masters.Equipment.Datas.FirstOrDefault(e => e.id == id);
		if (equipmentMaster != null)
		{
			equipmentModel.Add(Equipment.Create(equipmentMaster));
		}
	}
}
