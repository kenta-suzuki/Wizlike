using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class TitleView : MonoBehaviour
{
	[SerializeField]
	Image BG;
	[SerializeField]
	Text Title;
	[SerializeField]
	CommonButton StarButton;
	[SerializeField]
	CommonButton LoadButton;

	public event Action StarButtonSubmit;
	public event Action LoadButtonSubmit;

	public void Initialize()
	{
		StarButton.Tapped = StarButtonSubmit;
		LoadButton.Tapped = LoadButtonSubmit;
	}

	public void Show(bool hasData)
	{
		gameObject.SetActive(true);
		LoadButton.gameObject.SetActive(!hasData);
	}

	public void Hide()
	{
		gameObject.SetActive(false);
	}
}