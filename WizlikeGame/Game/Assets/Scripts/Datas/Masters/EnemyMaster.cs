using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class EnemyMaster : MasterBase
	{
		public string name { get; private set; }
		public int lv { get; private set; }
		public int strong { get; private set; }
		public int intelligence { get; private set; }
		public int mystery { get; private set; }
		public int agile { get; private set; }
		public int vital { get; private set; }
		public int luck { get; private set; }
		public int magic { get; private set; }
		public string behavior_ids { get; private set; } //ここはBehaviorがマスターに追加されたら別のゲッター作る

		public string parameters { get; private set; }

		public override string ToString()
		{
			return string.Format("[EnemyMaster: name={0}, lv={1}, strong={2}, intelligence={3}, mystery={4}, agile={5}, vital={6}, luck={7}, magic={8}, behavior_ids={9}, parameters={10}]", name, lv, strong, intelligence, mystery, agile, vital, luck, magic, behavior_ids, parameters);
		}
	}

	public class EnemyMasterTable : MasterTableBase<EnemyMaster>
	{
		static readonly string FilePath = "EnemyMaster";
		public void Load() { Load(FilePath); }
	}
}