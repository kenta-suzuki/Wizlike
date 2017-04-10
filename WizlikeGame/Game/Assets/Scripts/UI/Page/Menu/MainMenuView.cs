using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Data.Model;
using System;

public class MainMenuView : MonoBehaviour
{
	[SerializeField]
	TopMenuPanel TopMenuPanel;
	[SerializeField]
	Image BG;
	public Sprite BGSprite { set { BG.sprite = value; } }
	[SerializeField]
	CommonButton DepartureButton;
	[SerializeField]
	CommonButton SaveButton;
	[SerializeField]
	CommonButton LoadButton;

	public event Action DepartureButtonClicked;
	public event Action SaveButtonClicked;
	public event Action LoadButtonClicked;
	public event Action LeftButtonClicked;
	public event Action RightButtonClicked;

	public void Initialize()
	{
		DepartureButton.Tapped = DepartureButtonClicked;
		SaveButton.Tapped = SaveButtonClicked;
		LoadButton.Tapped = LoadButtonClicked;
	}

	void SetBG()
	{
		BGSprite = Resources.Load<Sprite>("Images/BG/Page/base");
	}

	public void Show()
	{
		TopMenuPanel.SetButton(LeftButtonClicked, RightButtonClicked, "紹介所", "宿屋");
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}
