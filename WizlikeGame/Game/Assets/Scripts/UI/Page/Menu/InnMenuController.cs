using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InnMenuController : MonoBehaviour,IPageController
{
	[SerializeField]
	InnMenuView View;
	[SerializeField]
	PageManager Manager;
	[SerializeField]
	MainMenuController MainMenuController;

	public string Name { get { return "IinMenu";} }


	public void Initialize()
	{
		var bgSprite = Resources.Load<Sprite>("Images/BG/Page/base");
		View.StayButtonClicked += () => OnStayButtonClick();
		View.LeftButtonClicked += () => OnLeftButtonClick();
		View.RightButtonClicked += () => OnRightButtonClick();

		View.BGSprite = bgSprite;
	}

	public void Show()
	{
		View.Show();
	}

	public void Hide()
	{
		View.Hide();
	}

	void OnStayButtonClick()
	{
		ConfirmDialog.CreateDialog(View.transform.parent, "泊まりますか?", "1000ゴールドになります", OnOkButtonClick);
	}

	void OnLeftButtonClick()
	{
	}

	void OnRightButtonClick()
	{
	}

	void OnOkButtonClick()
	{
	}
}
