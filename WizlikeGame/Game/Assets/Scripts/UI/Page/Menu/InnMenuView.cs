using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class InnMenuView : MonoBehaviour
{
	[SerializeField]
	TopMenuPanel TopMenuPanel;
	[SerializeField]
	Image BG;
	public Sprite BGSprite { set { BG.sprite = value; } }
	[SerializeField]
	CommonButton StayButton;

	public event Action StayButtonClicked;
	public event Action LeftButtonClicked;
	public event Action RightButtonClicked;

	public void Show()
	{
		StayButton.Tapped = StayButtonClicked;
		TopMenuPanel.SetButton(LeftButtonClicked, RightButtonClicked, "拠点", "商店");
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}
