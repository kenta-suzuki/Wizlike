using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class JobMaster : MasterBase
	{
		public Job job { get; private set; }

		public override string ToString()
		{
			return string.Format("[JobMaster: job={0}]", job);
		}
	}

	public class JobMasterTable : MasterTableBase<JobMaster>
	{
		static readonly string FilePath = "JobMaster";
		public void Load() { Load(FilePath); }
	}
}