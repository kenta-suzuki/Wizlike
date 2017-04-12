using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Model;
using System.Linq;

public class DangeonWall : MonoBehaviour 
{
	[SerializeField]
	bool IsDoor;
	[SerializeField]
	string KeyItemName;
	bool IsNeedKey { get { return string.IsNullOrEmpty(KeyItemName); } }
	[SerializeField]
	Texture texture;

	public void SetWallActive(bool isActive)
	{
		gameObject.SetActive(isActive);
	}

	public void Initialize()
	{
		var isWall = gameObject.activeSelf;
		gameObject.SetActive(isWall || IsDoor);

		if (IsNeedKey)
		{
			//鍵が必要なときのtextureセット
		}
		else
		{
			//鍵が必要でないときのtextureセット
		}
	}

	public bool CanMove(List<Item> items)
	{
		if (!IsDoor) return false;
		if (!IsNeedKey) return true;
		var hasKey = items.FirstOrDefault(item => item.name == KeyItemName) != null;
		return hasKey;
	}
}
