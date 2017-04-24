using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class CharacterMaster : MasterBase
	{
		public string tribe { get; private set; }
		public string description { get; private set; }

		public int strong { get; private set;}
		public int intelligence { get; private set;}
		public int mystery { get; private set;}
		public int agile { get; private set;}
		public int vital { get; private set;}
		public int luck { get; private set;}
		public int magic { get; private set; }

		public override string ToString()
		{
			return string.Format("[CharacterMaster: tribe={0}, description={1}, strong={2}, intelligence={3}, mystery={4}, agile={5}, vital={6}, luck={7}, magic={8}]", tribe, description, strong, intelligence, mystery, agile, vital, luck, magic);
		}
	}

	public class CharacterMasterTable : MasterTableBase<CharacterMaster>
	{
		static readonly string FilePath = "CharacterMaster";
		public void Load() { Load(FilePath); }
	}
}