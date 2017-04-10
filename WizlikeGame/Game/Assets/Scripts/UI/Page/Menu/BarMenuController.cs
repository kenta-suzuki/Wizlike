using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarMenuController : MonoBehaviour, IPageController
{
	[SerializeField]
	BarMenuView View;

	public string Name { get { return "BarMenu"; } }

	public void Initialize()
	{
		View.LeftButtonClicked += () => OnLeftButtonClick();
		View.RightButtonClicked += () => OnRightButtonClick();
		View.AddMemberButtonClicked += () => OnAddMemberButtonClick();
		View.RejectMemberButtonClicked += () => OnRejectMemberButtonClick();
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

	void OnAddMemberButtonClick()
	{
	}

	void OnRejectMemberButtonClick()
	{
	}

	void OnLeftButtonClick()
	{
		PageManager.Insatance.ShowPage("IinMenu");
	}

	void OnRightButtonClick()
	{
		PageManager.Insatance.ShowPage("ShopMenu");
	}
}
