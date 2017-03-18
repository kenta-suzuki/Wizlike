using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class StoryMaster : MasterBase
	{
		//特にまだ考えていない
	}

	public class StoryMasterTable : MasterTableBase<StoryMaster>
	{
		static readonly string FilePath = "StoryMaster";
		public void Load() { Load(FilePath); }
	}
}
