using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class IconMaster : MasterBase
	{
		public string icon_path { get; private set; }

		public override string ToString()
		{
			return string.Format("[IconMaster: path={0}]", icon_path);
		}
	}

	public class IconMasterTable : MasterTableBase<IconMaster>
	{
		static readonly string FilePath = "IconMaster";
		public void Load() { Load(FilePath); }
	}
}