using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class BehaviorMaster : MasterBase
	{
		public int skill_id { get; private set; }
		public int waiting_turn { get; private set; }

		public override string ToString()
		{
			return string.Format("[BehaviorMaster: skill_id={0}, waiting_turn={1}]", skill_id, waiting_turn);
		}
	}

	public class BehaviorMasterTable : MasterTableBase<BehaviorMaster>
	{
		static readonly string FilePath = "BehaviorMaster";
		public void Load() { Load(FilePath); }
	}
}
