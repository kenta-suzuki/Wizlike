using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class WaveMaster : MasterBase
	{
		public string front_enemy_ids { get; private set; }
		public string back_enemy_ids { get; private set; }

		public override string ToString()
		{
			return string.Format("[WaveMaster: front_enemy_ids={0}, back_enemy_ids={1}]", front_enemy_ids, back_enemy_ids);
		}
	}

	public class WaveMasterTable : MasterTableBase<WaveMaster>
	{
		static readonly string FilePath = "WaveMaster";
		public void Load() { Load(FilePath); }
	}
}

