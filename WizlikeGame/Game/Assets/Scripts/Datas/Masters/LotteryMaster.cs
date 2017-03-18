using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class LotteryMaster : MasterBase
	{
		public int item_id { get; private set; }
		public int equipment_id { get; private set; }
		public int lottery { get; private set; }
		public int enchant_id { get; private set; }
	}

	public class LotteryMasterTable : MasterTableBase<LotteryMaster>
	{
		static readonly string FilePath = "LotteryMaster";
		public void Load() { Load(FilePath); }
	}
}