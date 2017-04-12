using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public class DangeonManager : MonoBehaviour
{
	[SerializeField]
	DangeonPlayerMotor PlayerMotor;
	[SerializeField]
	DangeonPlayer Player;
	[SerializeField]
	Transform StartPosition;
	
	List<DangeonTile> DangeonTiles;

	void Start ()
	{
		DangeonTiles = GetComponentsInChildren<DangeonTile>().ToList();
		DangeonTiles.ForEach(tile => tile.Initialize());

		PlayerMotor.transform.position = new Vector3(StartPosition.position.x, PlayerMotor.transform.position.y, StartPosition.position.z);
		PlayerMotor.MoveFinished += () => Encount();
		PlayerMotor.Initialize();

		Player.Initialize();
	}

	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{
			if (!CanMoveTile()) return;
			MovePlayer();

		}
		else if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			PlayerRotation(false);
		}
		else if (Input.GetKeyDown(KeyCode.LeftArrow))
		{
			PlayerRotation(true);
		}
	}

	//ここにドアの場合の処理を追加
	bool CanMoveTile()
	{
		RaycastHit hit;
		if (!Physics.Raycast(PlayerMotor.transform.position, PlayerMotor.transform.forward, out hit, 5))return true;

		var obj = hit.collider.gameObject;
		var wall = hit.collider.gameObject.GetComponent<DangeonWall>();

		return wall.CanMove(Player.Items);
	}

	void Encount()
	{
		RaycastHit hit;
		if (!Physics.Raycast(PlayerMotor.transform.position, PlayerMotor.transform.up * -1, out hit, 5)) return;
		var tile = hit.collider.gameObject.GetComponentInParent<DangeonTile>();

		if (tile.HasItem)
		{
			Player.ReciveItem(tile.GetItem());
			return;
		}

		var waveNo = tile.Encount();
		if (waveNo != -1) ChangeBattleScene(waveNo);

	}

	void MovePlayer()
	{
		PlayerMotor.Move();
	}

	void PlayerRotation(bool isLeft)
	{
		PlayerMotor.Rotate(isLeft);
	}

	void ChangeBattleScene(int waveNo)
	{
	}
}
