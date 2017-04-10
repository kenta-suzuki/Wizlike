using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;
using System.Linq;

namespace Data.Model
{
	public class EquipmentModel
	{
		const string key = "equipment";
		public List<Equipment> Equipments;
		public bool HasEquipmentData { get { return PlayerPrefs.HasKey(key); } }

		public void Initialize()
		{
			Equipments = new List<Equipment>();
			if (HasEquipmentData)
			{
				Load();
			}
		}

		void Clear()
		{
			Equipments.Clear();
		}

		public void Load()
		{
			Clear();
			JSONObjectExtension.ToStringList(PlayerPrefs.GetString(key)).ForEach(e => Add(Equipment.Create(e)));
		}

		public void CreateNewData()
		{
			var equipment = Equipment.Create(GameModel.Instance.Masters.Equipment.Datas.First(e => e.id == 1));
			Add(equipment);
		}

		public void Add(Equipment equipment)
		{
			Equipments.Add(equipment);
		}

		public void Remove(Equipment equipment)
		{
			Equipments.Remove(equipment);
		}

		public void Save()
		{
			PlayerPrefs.SetString(key, Equipments.Select(e => e.ToString()).ToList().ToJsonString());
		}
	}
}