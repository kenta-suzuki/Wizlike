using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class StageMaster : MasterBase
	{
		public string name { get; private set; }
	}

	public class StageMasterTable : MasterTableBase<StageMaster>
	{
		static readonly string FilePath = "StageMaster";
		public void Load() { Load(FilePath); }
	}
}