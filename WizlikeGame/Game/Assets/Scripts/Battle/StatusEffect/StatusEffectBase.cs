using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
	public class StatusEffectBase
	{
		Damage Damage { get; set; }
		public StatusEffectType Type { get; private set; }

		public void PerformStatusEffect(CharacterBase reciver)
		{
			CreateDamage();
			reciver.ApplayDamage(Damage);
		}

		public virtual void CreateDamage()
		{
		}
	}
}