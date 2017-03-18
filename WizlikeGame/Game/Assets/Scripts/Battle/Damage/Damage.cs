using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
	public class Damage
	{
		public int Value { get; private set; }
		public StatusEffectBase StatusEffect { get; private set; }
		public Blocker Blocker { get; private set; }
	}
}
