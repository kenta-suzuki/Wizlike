using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Data.Master;

public class DangeonTile : MonoBehaviour 
{
	[SerializeField]
	List<DangeonWall> WallTypes;

	[SerializeField]
	DangeonEncounter Encounter;
	[SerializeField]
	FloorType FloorType;
	[SerializeField]
	int ItemId = -1;
	public bool HasItem { get { return ItemId != -1; } }
	[SerializeField]
	int WaveNo; //エンカウントするウェーブの情報

	bool IsReached;

	public void Initialize()
	{
		IsReached = false;
		WallTypes.ForEach((type, index) => type.Initialize());
	}

	public int Encount()
	{
		IsReached = true;
		var waveNo = -1;
		if (FloorType == FloorType.hole) return waveNo;
		if (Encounter.Encount()) waveNo = WaveNo;

		return waveNo;
	}

	public int GetItem()
	{
		return ItemId;
	}
}
