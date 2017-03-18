using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health
{
	public int HP { get; private set;}
	public bool IsDead { get { return HP <= 0; } }

	public Health(int hp)
	{
		HP = hp;
	}

	public void AddDamage(int damage)
	{
		HP -= damage;
	}
}
