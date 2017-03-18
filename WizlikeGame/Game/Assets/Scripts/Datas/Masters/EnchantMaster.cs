using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class EnchantMaster : MasterBase
	{
		public string name { get; private set;}
		public WeaponType weapon_type { get; private set;} //付加することが可能な武器
		//public EnchantType type { get; private set;} //装備に付加する効果
		public int enchant_power { get; private set;} //装備に付加する強さ
		public int lottery { get; private set;} //確率
	}

	public class EnchantMasterTable : MasterTableBase<EnchantMaster>
	{
		static readonly string FilePath = "EnchantMaster";
		public void Load() { Load(FilePath); }
	}
}