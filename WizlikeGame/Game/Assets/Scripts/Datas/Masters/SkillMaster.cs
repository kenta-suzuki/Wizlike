using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class SkillMaster : MasterBase
	{
		public string name { get; private set; }
		public string script { get; private set;}
		public Target target { get; private set; }
		public SelectType select_type { get; private set; }
		public string description { get; private set; }
		public string parameters { get; private set;}

		public override string ToString()
		{
			return string.Format("[SkillMaster: name={0}, script={1}, target={2}, select_type={3}, description={4}, parameters={5}]", name, script, target, select_type, description, parameters);
		}
	}

	public class SkillMasterTable : MasterTableBase<SkillMaster>
	{
		static readonly string FilePath = "SkillMaster";
		public void Load() { Load(FilePath); }
	}
}