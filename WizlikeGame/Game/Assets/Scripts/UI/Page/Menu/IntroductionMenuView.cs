using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class IntroductionMenuView : MonoBehaviour
{
	[SerializeField]
	TopMenuPanel TopMenuPanel;
	[SerializeField]
	CommonButton RegistButton;
	[SerializeField]
	CommonButton RemoveButton;
	[SerializeField]
	CommonButton RenameButton;
	[SerializeField]
	Image BG;
	public Sprite BGSprite { set { BG.sprite = value; } }

	public event Action RegistButtonClicked;
	public event Action RemoveButtonClicked;
	public event Action RenameButtonClicked;
	public event Action LeftButtonClicked;
	public event Action RightButtonClicked;

	public void Initialize()
	{
		RegistButton.Tapped = RegistButtonClicked;
		RemoveButton.Tapped = RemoveButtonClicked;
		RenameButton.Tapped = RenameButtonClicked;
	}

	void SetBG()
	{
		BGSprite = Resources.Load<Sprite>("Images/BG/Page/base");
	}

	public void Show()
	{
		TopMenuPanel.SetButton(LeftButtonClicked, RightButtonClicked, "商店", "拠点");
		gameObject.SetActive(true);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}
