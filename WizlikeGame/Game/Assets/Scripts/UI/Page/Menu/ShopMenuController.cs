using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopMenuController : MonoBehaviour, IPageController
{
	[SerializeField]
	ShopMenuView View;

	public string Name { get { return "ShopMenu"; } }

	public void Initialize()
	{
		View.LeftButtonClicked += () => OnLeftButtonClick();
		View.RightButtonClicked += () => OnRightButtonClick();
		View.BuyButtonClicked += () => OnBuyButtonClick();
		View.SellButtonClicked += () => OnSellButtonClick();
		View.Initialize();
	}

	public void Show()
	{
		View.Show();
	}

	public void Hide()
	{
		View.Hide();
	}

	void OnBuyButtonClick()
	{
	}

	void OnSellButtonClick()
	{
	}

	void OnLeftButtonClick()
	{
		PageManager.Insatance.ShowPage("BarMenu");
	}

	void OnRightButtonClick()
	{
		PageManager.Insatance.ShowPage("IntroductionMenu");
	}
}
