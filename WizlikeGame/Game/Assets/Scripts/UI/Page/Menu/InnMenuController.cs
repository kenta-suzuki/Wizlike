using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnMenuController : MonoBehaviour,IPageController
{
	[SerializeField]
	InnMenuView View;

	public string Name { get { return "IinMenu";} }


	public void Initialize()
	{
		View.StayButtonClicked += () => OnStayButtonClick();
		View.LeftButtonClicked += () => OnLeftButtonClick();
		View.RightButtonClicked += () => OnRightButtonClick();
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

	int GetStayPrice()
	{
		return 1000;
	}

	void OnStayButtonClick()
	{
		ConfirmDialog.CreateDialog(View.transform.parent, "泊まりますか?", GetStayPrice().ToString() + "ゴールドになります", OnOkButtonClick);
	}

	void OnLeftButtonClick()
	{
		PageManager.Insatance.ShowPage("MainMenu");
	}

	void OnRightButtonClick()
	{
		PageManager.Insatance.ShowPage("BarMenu");
	}

	void OnOkButtonClick()
	{
	}
}
