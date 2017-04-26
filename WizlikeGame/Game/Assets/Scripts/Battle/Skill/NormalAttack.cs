using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
	public class NormalAttack : SkillBase
	{
		public NormalAttack(BattleCharacter attacker)
		{
			Attacker = attacker;
		}

		public void SetReciver(BattleCharacter reciver)
		{
			Recivers.Add(reciver);
		}
	}
}
