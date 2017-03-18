using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class CharacterMaster : MasterBase
	{
		public int strong { get; private set;}
		public int intelligence { get; private set;}
		public int mystery { get; private set;}
		public int agile { get; private set;}
		public int vital { get; private set;}
		public int luck { get; private set;}

		public override string ToString()
		{
			return string.Format("[CharacterMaster: strong={0}, intelligence={1}, mystery={2}, agile={3}, vital={4}, luck={5}]", strong, intelligence, mystery, agile, vital, luck);
		}
	}

	public class CharacterMasterTable : MasterTableBase<CharacterMaster>
	{
		static readonly string FilePath = "CharacterMaster";
		public void Load() { Load(FilePath); }
	}
}