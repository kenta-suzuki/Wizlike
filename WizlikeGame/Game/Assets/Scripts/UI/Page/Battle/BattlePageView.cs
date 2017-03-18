using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Linq;

public class BattlePageView : MonoBehaviour
{
	[SerializeField]
	GameObject Root;
	[SerializeField]
	PartyView PartyView;

	[SerializeField]
	CommonButton AttackButton;
	[SerializeField]
	CommonButton DefenseButton;
	[SerializeField]
	CommonButton SkillButton;
	[SerializeField]
	CommonButton ItemButton;

	[SerializeField]
	EnemyView EnemyView;
	[SerializeField]
	CommonInfoView InformationView;
	[SerializeField]
	CommonBG BG;
	[SerializeField]
	CommonSelectScrollView SelectScrollView;

	public event Action<Message> InfomationChanged;
	public event Action AttackButtonTapped;
	public event Action DefenseButtonTapped;
	public event Action SkillButtonTapped;
	public event Action ItemButtonTapped;

	public void Initialize()
	{
		AttackButton.Tapped = AttackButtonTapped;
		DefenseButton.Tapped = DefenseButtonTapped;
		SkillButton.Tapped = SkillButtonTapped;
		ItemButton.Tapped = ItemButtonTapped;
		AttackButton.Select();

		PartyView.Initialize();
		EnemyView.Initialize();
		BG.Initialize();
	}

	public void EnableSelectScrollView(bool isActive)
	{
		SelectScrollView.gameObject.SetActive(isActive);
	}
}
