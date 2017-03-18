using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class EquipmentMaster : MasterBase
	{
		public string name { get; private set; }
		public int strong { get; private set; }
		public int intelligence { get; private set; }
		public int mystery { get; private set; }
		public int agile { get; private set; }
		public int vital { get; private set; }
		public int luck { get; private set; }
		public int accuracy { get; private set; }
		public int physical_power { get; private set; }
		public int physical_defense { get; private set; }
		public int magical_power { get; private set; }
		public int magical_defense { get; private set; }
		public Attribute attribute { get; private set; }
		public Tribe regist_tribe_1 { get; private set; }
		public Tribe regist_tribe_2 { get; private set; }
		public Tribe regist_tribe_3 { get; private set; }

		public override string ToString()
		{
			return string.Format("[EquipmentMaster: name={0}, strong={1}, intelligence={2}, mystery={3}, agile={4}, vital={5}, luck={6}, accuracy={7}, physical_power={8}, physical_defense={9}, magical_power={10}, magical_defense={11}, attribute={12}, regist_tribe_1={13}, regist_tribe_2={14}, regist_tribe_3={15}]", name, strong, intelligence, mystery, agile, vital, luck, accuracy, physical_power, physical_defense, magical_power, magical_defense, attribute, regist_tribe_1, regist_tribe_2, regist_tribe_3);
		}
	}

	public class EquipmentMasterTable : MasterTableBase<EquipmentMaster>
	{
		static readonly string FilePath = "EquipmentMaster";
		public void Load() { Load(FilePath); }
	}
}
