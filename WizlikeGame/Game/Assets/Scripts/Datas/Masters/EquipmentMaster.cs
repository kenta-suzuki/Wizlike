using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class EquipmentMaster : MasterBase
	{
		public string name { get; private set; }
		public string not_found_name { get; private set; }
		public WeaponType type { get; private set; }
		public int power { get; private set; }
		public int deffense { get; private set; }
		public int avoidance { get; private set; }
		public int hit { get; private set; }
		public Attribute attribute { get; private set; }
		public EnemyTribe regist_tribe { get; private set; }
		public string parameters { get; private set; }

		public override string ToString()
		{
			return string.Format("[EquipmentMaster: name={0}, not_found_name={1}, type={2}, power={3}, deffense={4}, avoidance={5}, hit={6}, parameters={7}]", name, not_found_name, type, power, deffense, avoidance, hit, parameters);
		}
	}

	public class EquipmentMasterTable : MasterTableBase<EquipmentMaster>
	{
		static readonly string FilePath = "EquipmentMaster";
		public void Load() { Load(FilePath); }
	}
}
