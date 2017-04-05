using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TopMenuPanel : MonoBehaviour
{
	[SerializeField]
	CommonButton LeftButton;
	[SerializeField]
	CommonButton RightButton;

	public void SetButton(Action leftButtonClicked, Action rightButtonClicked, string leftText, string rightText)
	{
		LeftButton.Tapped = leftButtonClicked;
		RightButton.Tapped = rightButtonClicked;
		LeftButton.Text = leftText;
		RightButton.Text = rightText;
	}
}
