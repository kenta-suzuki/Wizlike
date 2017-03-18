using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleController : MonoBehaviour
{
	[SerializeField]
	TitleView View;

	public void Initialize()
	{
		View.StarButtonSubmit += ()=> OnStartSubmit();
		View.LoadButtonSubmit += () => OnLoadSubmit();
	}

	public void Show()
	{
		View.Show(GameModel.Instance.Models.HasModel);
	}

	void Hide()
	{
		View.Hide();
	}

	void OnStartSubmit()
	{
	}

	void OnLoadSubmit()
	{
	}
}
