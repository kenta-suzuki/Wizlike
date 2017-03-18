using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;

namespace Data.Model
{
	public class PlayerModel
	{
		const string Key = "PlayerData";
		public Player Player { get; private set; }
		public bool HasPlayerData { get { return PlayerPrefs.HasKey(Key); } }

		public void Initialize()
		{
			if (HasPlayerData)
			{
				LoadPlayerData();
				Save();
			}
			CreateNewData();
			Save();
		}

		void LoadPlayerData()
		{
			Player = Player.Create(PlayerPrefs.GetString(Key));
		}

		public void CreateNewData()
		{
			Player = new Player(1000);
		}

		public void Save()
		{
			PlayerPrefs.SetString(Key, Player.ToString());
		}
	}
}
