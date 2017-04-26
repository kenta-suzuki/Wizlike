using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Master
{
	public class Masters
	{
		public CharacterMasterTable Character { get; private set; }
		public EquipmentMasterTable Equipment { get; private set; }
		public EnemyMasterTable Enemy { get; private set; }
		public SkillMasterTable Skill { get; private set;}
		public ItemMasterTable Item { get; private set;}
		public JobMasterTable Job { get; private set;}
		public IconMasterTable Icon { get; private set;}
		public WaveMasterTable Wave { get; private set; }
		public BehaviorMasterTable Behavior { get; private set; }

		public void Initialize()
		{
			Character = new CharacterMasterTable();
			Equipment = new EquipmentMasterTable();
			Enemy = new EnemyMasterTable();
			Item = new ItemMasterTable();
			Job = new JobMasterTable();
			Icon = new IconMasterTable();
			Skill = new SkillMasterTable();
			Wave = new WaveMasterTable();
			Behavior = new BehaviorMasterTable();

			Character.Load();
			Equipment.Load();
			Enemy.Load();
			Item.Load();
			Job.Load();
			Icon.Load();
			Skill.Load();
			Wave.Load();
			Behavior.Load();

		}
	}
}