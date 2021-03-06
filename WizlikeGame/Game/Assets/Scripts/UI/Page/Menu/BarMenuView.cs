﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class BarMenuView : MonoBehaviour 
{
	[SerializeField]
	TopMenuPanel TopMenuPanel;
	[SerializeField]
	CommonButton AddMemberButton;
	[SerializeField]
	CommonButton RejectMemberButton;
	[SerializeField]
	Image BG;
	public Sprite BGSprite { set { BG.sprite = value; } }

	public event Action AddMemberButtonClicked;
	public event Action RejectMemberButtonClicked;
	public event Action LeftButtonClicked;
	public event Action RightButtonClicked;

	public void Initialize()
	{
		AddMemberButton.Tapped = AddMemberButtonClicked;
		RejectMemberButton.Tapped = RejectMemberButtonClicked;
	}

	void SetBG()
	{
		BGSprite = Resources.Load<Sprite>("Images/BG/Page/base");
	}

	public void Show()
	{
		TopMenuPanel.SetButton(LeftButtonClicked, RightButtonClicked, "宿屋", "商店");
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}
