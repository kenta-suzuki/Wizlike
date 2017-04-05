using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour, IPageController
{
	[SerializeField]
	MainMenuView View;
	[SerializeField]
	PageManager Manager;

	public string Name { get { return "MainMenu";} }

	public void Initialize()
	{
		Debug.Log("initialized");
		var bgSprite = Resources.Load<Sprite>("Images/BG/Page/base");
		View.DepartureButtonClicked += () => OnDepartureButtonClick();
		View.SaveButtonClicked += () => OnSaveButtonClick();
		View.LoadButtonClicked += () => OnLoadButtonClick();
		View.LeftButtonClicked += () => OnLeftButtonClick();
		View.RightButtonClicked += () => OnRightButtonClick();

		View.BGSprite = bgSprite;
	}
	
	public void Show()
	{
		Debug.Log("show");
		View.Show();
	}

	public void Hide()
	{
		View.Hide();
	}

	void OnInnButtonClick()
	{
		Debug.Log("宿屋");
	}

	void OnBarButtonClick()
	{
		Debug.Log("酒場");
	}

	void OnDepartureButtonClick()
	{
		Debug.Log("出発");
	}

	void OnSaveButtonClick()
	{
		Debug.Log("セーブ画面");
	}

	void OnLoadButtonClick()
	{
		Debug.Log("ロード画面");
	}

	void OnLeftButtonClick()
	{
		Debug.Log("紹介所");
	}

	void OnRightButtonClick()
	{
		Manager.ShowPage("IinMenu");
	}
}
