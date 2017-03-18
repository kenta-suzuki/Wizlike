using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
	public abstract class SkillBase
	{
		CharacterBase Attacker { get; set; }
		List<CharacterBase> Recivers { get; set; }
		Damage Damage { get; set; }

		//BattleManagerから呼ばれる
		public void PerformSkill()
		{
			Recivers.ForEach(reciver => ApplyDamage(reciver));
		}

		protected void ApplyDamage(CharacterBase reciver)
		{
			CreateDamage(reciver);
			reciver.ApplayDamage(Damage);
		}

		protected virtual void CreateDamage(CharacterBase reciver)
		{
		}

		protected virtual void CreateStatusEffect()
		{
		}
	}

}