using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;

public class DangeonEncounter : MonoBehaviour 
{
	//ウェーブ情報当て込む
	[SerializeField]
	int Range;
	[SerializeField]
	int HitRange;

	//ウェーブ情報から算出してエンカウントしたかどうかの処理を行う
	public bool Encount()
	{
		var rand = Random.Range(0, Range);
		return rand < HitRange;
	}
}
