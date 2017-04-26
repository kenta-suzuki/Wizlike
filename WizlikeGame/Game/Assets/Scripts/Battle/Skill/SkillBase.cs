using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
	public abstract class SkillBase : ISkillPerform
	{
		protected BattleCharacter Attacker { get; set; }
		protected List<BattleCharacter> Recivers { get; set; }
		protected Damage Damage { get; set; }

		//BattleManagerから呼ばれる
		public void PerformSkill()
		{
			Recivers.ForEach(reciver => ApplyDamage(reciver));
		}

		protected void ApplyDamage(BattleCharacter reciver)
		{
			CreateDamage(reciver);
			reciver.ApplayDamage(Damage);
		}

		protected virtual void CreateDamage(BattleCharacter reciver)
		{
		}

		protected virtual void CreateStatusEffect()
		{
		}
	}

}