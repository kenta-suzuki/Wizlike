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

	public void Initialize()
	{
		StayButton.Tapped = StayButtonClicked;
	}

	void SetBG()
	{
		BGSprite = Resources.Load<Sprite>("Images/BG/Page/base");
	}

	public void Show()
	{
		TopMenuPanel.SetButton(LeftButtonClicked, RightButtonClicked, "拠点", "酒場");
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}
