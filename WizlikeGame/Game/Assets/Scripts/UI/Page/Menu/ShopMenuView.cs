using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class ShopMenuView : MonoBehaviour
{
	[SerializeField]
	TopMenuPanel TopMenuPanel;
	[SerializeField]
	CommonButton BuyButton;
	[SerializeField]
	CommonButton SellButton;
	[SerializeField]
	CommonButton AppraisalButton;
	[SerializeField]
	Image BG;
	public Sprite BGSprite { set { BG.sprite = value; } }

	public event Action BuyButtonClicked;
	public event Action SellButtonClicked;
	public event Action LeftButtonClicked;
	public event Action RightButtonClicked;

	public void Initialize()
	{
		BuyButton.Tapped = BuyButtonClicked;
		SellButton.Tapped = SellButtonClicked;
	}

	void SetBG()
	{
		BGSprite = Resources.Load<Sprite>("Images/BG/Page/base");
	}

	public void Show()
	{
		TopMenuPanel.SetButton(LeftButtonClicked, RightButtonClicked, "酒場", "紹介所");
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}
