using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class StatusEffectMaster : MasterBase
	{
		public string name { get; private set;}
		public string script_name { get; private set;}
	}

	public class StatusEffectMasterTable : MasterTableBase<StatusEffectMaster>
	{
		static readonly string FilePath = "StatusEffectMaster";
		public void Load() { Load(FilePath); }
	}
}
