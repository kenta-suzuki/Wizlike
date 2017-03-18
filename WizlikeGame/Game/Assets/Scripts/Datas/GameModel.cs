using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;
using Data.Model;

public class GameModel
{
	static GameModel _instance;
	public static GameModel Instance { get { return _instance; } }

	public bool IsLoading { get; private set;}
	public Masters Masters { get; private set; }
	public Models Models { get; private set; }

	public void Initialize()
	{
		IsLoading = true;
		_instance = this;
		Masters = new Masters();
		Masters.Initialize();
		Models = new Models();
		Models.Initialize();
		IsLoading = false;
	}
}
