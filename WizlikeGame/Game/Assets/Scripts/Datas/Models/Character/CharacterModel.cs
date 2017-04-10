using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Data.Master;

namespace Data.Model
{
	public class CharacterModel
	{
		const string key = "character";
		public List<Character> Characters;
		public bool HasCharacterData { get { return PlayerPrefs.HasKey(key); } }

		public void Initialize()
		{
			Characters = new List<Character>();
			if (HasCharacterData)
			{
				Load();
			}
		}

		void Clear()
		{
			Characters.Clear();
		}

		public void Load()
		{
			Clear();
			JSONObjectExtension.ToStringList(PlayerPrefs.GetString(key)).ForEach(c => Add(Character.Create(c)));
		}

		public void CreateNewData(CharacterMaster master, string name, Job job)
		{
			Add(Character.Create(master, name, job));
		}

		public void Add(Character character)
		{
			Characters.Add(character);
		}

		public void Remove(Character character)
		{
			Characters.Remove(character);
		}

		public void Save()
		{
			PlayerPrefs.SetString(key, Characters.Select(e => e.ToString()).ToList().ToJsonString());
		}
	}
}