using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour, IPageController
{
	[SerializeField]
	TitleView View;

	public string Name { get { return "Title"; } }

	public void Initialize()
	{
		View.StarButtonSubmit += ()=> OnStartSubmit();
		View.LoadButtonSubmit += () => OnLoadSubmit();
		View.Initialize();
	}

	public void Show()
	{
		View.Show(GameModel.Instance.Models.HasModel);
	}

	public void Hide()
	{
		View.Hide();
	}

	void OnStartSubmit()
	{
		GameModel.Instance.Models.Initialize();
		SceneChangeManager.Load("Menu", View.transform);
	}

	void OnLoadSubmit()
	{
		GameModel.Instance.Models.Load();
		SceneChangeManager.Load("Menu");
	}
}
