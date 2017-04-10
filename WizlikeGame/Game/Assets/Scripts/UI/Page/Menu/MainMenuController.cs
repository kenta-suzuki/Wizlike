using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour, IPageController
{
	[SerializeField]
	MainMenuView View;

	public string Name { get { return "MainMenu";} }

	public void Initialize()
	{
		View.DepartureButtonClicked += () => OnDepartureButtonClick();
		View.SaveButtonClicked += () => OnSaveButtonClick();
		View.LoadButtonClicked += () => OnLoadButtonClick();
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

	void OnDepartureButtonClick()
	{
		Debug.Log("出発");
	}

	void OnSaveButtonClick()
	{
		ConfirmDialog.CreateDialog(View.transform, "セーブ", "セーブしますか？", () => GameModel.Instance.Models.Save());
	}

	void OnLoadButtonClick()
	{
		ConfirmDialog.CreateDialog(View.transform, "ロード", "ロードしますか？", () => GameModel.Instance.Models.Load());
	}

	void OnLeftButtonClick()
	{
		PageManager.Insatance.ShowPage("IntroductionMenu");
	}

	void OnRightButtonClick()
	{
		PageManager.Insatance.ShowPage("IinMenu");
	}
}
