using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BattlePageController : MonoBehaviour
{
	[SerializeField]
	BattlePageView View;

	public void Initialize()
	{
		View.AttackButtonTapped += OnAttackTap;
		View.DefenseButtonTapped += OnDefenseTap;
		View.SkillButtonTapped += OnSkillTap;
		View.ItemButtonTapped += OnItemTap;
		View.Initialize();
	}

	public void ChangeSelectCharacter(bool isCancel)
	{
	}

	void OnAttackTap()
	{
	}

	void OnDefenseTap()
	{
	}

	void OnSkillTap()
	{
	}

	void OnItemTap()
	{
	}
}
