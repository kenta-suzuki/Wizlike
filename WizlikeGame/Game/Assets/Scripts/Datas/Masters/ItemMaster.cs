using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class ItemMaster : MasterBase
	{
		public ItemType type { get; private set;}
		public string name { get; private set;}
		public string not_found_name { get; private set;}
		public string description { get; private set;}
		public int power { get; private set;}
		public int price { get; private set;}
		public int sell_price { get; private set;}
		public bool is_selling { get; private set;}

		public override string ToString()
		{
			return string.Format("[ItemMaster: type={0}, name={1}, not_found_name={2}, description={3}, power={4}, price={5}, sell_price={6}, is_selling={7}]", type, name, not_found_name, description, power, price, sell_price, is_selling);
		}
	}

	public class ItemMasterTable : MasterTableBase<ItemMaster>
	{
		static readonly string FilePath = "ItemMaster";
		public void Load() { Load(FilePath); }
	}
}