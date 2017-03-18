using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Battle;

public class Status
{
	public Blocker Blocker { get; private set;}
	public StatusEffectBase StatusEffect { get; private set;}
	CharacterBase Owner { get; set;}

	public Status(CharacterBase owner)
	{
		Owner = owner;
		Blocker = new Blocker(){ UnusablePlay = false, UnusableSkill = false };
		StatusEffect = null;
	}

	public void SetStatusEffect(StatusEffectBase statusEffect, Blocker blocker)
	{
		StatusEffect = statusEffect;
		Blocker = blocker;
	}

	public void RemoveStatusEffect()
	{
		StatusEffect = null;
		Blocker = new Blocker() { UnusablePlay = true, UnusableSkill = true };
	}

	//BattleManagerのターン終了時に呼ばれる
	public void FireEffect()
	{
		if (StatusEffect == null) return;
		StatusEffect.PerformStatusEffect(Owner);
	}
}
