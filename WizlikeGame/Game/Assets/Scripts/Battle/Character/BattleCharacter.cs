using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Battle;
using Data.Model;
using Data.Master;

public class BattleCharacter

{
	public long Id { get; private set;}
	public string Name { get; private set;}

	public Status Status { get; private set;}
	public Parameter Param { get; private set;}
	public Health Health { get; private set;}
	public List<Equipment> Equipments { get; private set;}
	public List<SkillMaster> Skills { get; private set;}

	public BattleCharacter(int id, Character character)
	{
		Id = id;
		Name = character.Name;
		Status = new Status(this);
		Param = new Parameter(character);
		Health = new Health(character.Vital);
		Equipments = character.Equipments;
		Skills = character.Skills;
	}

	public void ApplayDamage(Damage damage)
	{
		Health.AddDamage(damage.Value);
		Status.SetStatusEffect(damage.StatusEffect, damage.Blocker);
	}
}
