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

		public void Initialize()
		{
			Character = new CharacterMasterTable();
			Equipment = new EquipmentMasterTable();
			Enemy = new EnemyMasterTable();

			Character.Load();
			Equipment.Load();
			Enemy.Load();
			//Skill.Load();

		}
	}
}