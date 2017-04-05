using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour 
{

	// Use this for initialization
	void Start ()
	{
		PlayerPrefs.DeleteAll();
	}

	//マスターとモデルのロード
	IEnumerator WaitForLoadMasterData()
	{
		var gamemodel = new GameModel();
		gamemodel.Initialize();
		while (gamemodel.IsLoading)
		{
			yield return null;
		}
	}


}
