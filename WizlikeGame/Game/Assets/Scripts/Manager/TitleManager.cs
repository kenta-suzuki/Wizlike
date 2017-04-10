using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour 
{
	[SerializeField]
	TitleController controller;

	void Start ()
	{
		PlayerPrefs.DeleteAll();
		StartCoroutine(WaitForLoadMasterData());
		controller.Initialize();
	}

	IEnumerator WaitForLoadMasterData()
	{
		var gamemodel = new GameModel();
		gamemodel.Initialize();
		while (gamemodel.IsLoading)
		{
			yield return null;
		}
		controller.Show();
	}
}
