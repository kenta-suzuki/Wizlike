using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class AdventureMaster : MasterBase
	{
		//まだ考えてない
	}

	public class AdventureMasterTable : MasterTableBase<AdventureMaster>
	{
		static readonly string FilePath = "AdventureMaster";
		public void Load() { Load(FilePath); }
	}
}