using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class EnemyMaster : MasterBase
	{
		public string name { get; private set; }
		public int strong { get; private set; }
		public int intelligence { get; private set; }
		public int mystery { get; private set; }
		public int agile { get; private set; }
		public int vital { get; private set; }
		public int luck { get; private set; }
		public int physical_power { get; private set; }
		public int physical_defense { get; private set; }
		public int magical_power { get; private set; }
		public int magical_defense { get; private set; }
		public Attribute attribute { get; private set; }
		public int lottery_id { get; private set;}
		public int ai_id { get; private set;}
	}

	public class EnemyMasterTable : MasterTableBase<EnemyMaster>
	{
		static readonly string FilePath = "EnemyMaster";
		public void Load() { Load(FilePath); }
	}
}