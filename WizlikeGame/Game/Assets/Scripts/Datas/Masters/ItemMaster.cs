using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class ItemMaster : MasterBase
	{
		public ItemType type { get; private set;}
		public string name { get; private set;}
		public int power_value { get; private set;}
		public int sell_value { get; private set;}
	}

	public class ItemMasterTable : MasterTableBase<ItemMaster>
	{
		static readonly string FilePath = "ItemMaster";
		public void Load() { Load(FilePath); }
	}
}