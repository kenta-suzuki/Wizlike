using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Model
{
	public class Models
	{
		public PlayerModel Player { get; private set;}
		public EquipmentModel Equipment { get; private set;}
		public CharacterModel Character { get; private set;}
		public bool HasModel { get { return Player.HasPlayerData; } }


		public void Initialize()
		{
			Player = new PlayerModel();
			Player.Initialize();
			Equipment = new EquipmentModel();
			Equipment.Initialize();
			Character = new CharacterModel();
			Character.Initialize();
		}

		public void Save()
		{
			Player.Save();
			Equipment.Save();
			Character.Save();
		}

		public void Load()
		{
			Player.Load();
			Equipment.Load();
			Character.Load();
		}
	}
}
