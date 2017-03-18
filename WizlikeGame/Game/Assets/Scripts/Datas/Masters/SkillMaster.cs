using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class SkillMaster : MasterBase
	{
		public string name { get; private set;}
		public string parameter { get; private set;}
		public string script_name { get; private set;}
		public int statu_effect_id { get; private set;}
	}

	public class SkillMasterTable : MasterTableBase<SkillMaster>
	{
		static readonly string FilePath = "SkillMaster";
		public void Load() { Load(FilePath); }
	}
}