using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NormalAttack
{
	public CharacterBase Reciver { get; private set;}
	public CharacterBase Attacker { get; private set; }

	public NormalAttack(CharacterBase attacker)
	{
		Attacker = attacker;
	}
		

	public void SetReciver(CharacterBase reciver)
	{
		Reciver = reciver;
	}
}
