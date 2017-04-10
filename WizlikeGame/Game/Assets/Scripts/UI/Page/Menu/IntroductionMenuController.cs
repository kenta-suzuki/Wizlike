using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionMenuController : MonoBehaviour, IPageController 
{
	[SerializeField]
	IntroductionMenuView View;

	public string Name { get { return "IntroductionMenu"; } }

	public void Initialize()
	{
		View.LeftButtonClicked += () => OnLeftButtonClick();
		View.RightButtonClicked += () => OnRightButtonClick();
		View.RegistButtonClicked += () => OnRegistButtonClick();
		View.RemoveButtonClicked += () => OnRemoveButtonClick();
		View.RenameButtonClicked += () => OnRenameButtonClick();
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

	void OnRegistButtonClick()
	{
	}

	void OnRemoveButtonClick()
	{
	}

	void OnRenameButtonClick()
	{
	}

	void OnLeftButtonClick()
	{
		PageManager.Insatance.ShowPage("ShopMenu");
	}

	void OnRightButtonClick()
	{
		PageManager.Insatance.ShowPage("MainMenu");
	}
}
