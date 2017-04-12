using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;
using System.Linq;

public class DangeonDoor : MonoBehaviour
{
	[SerializeField]
	WallType WallType;
	[SerializeField]
	ItemMaster KeyItem;
	bool IsNeedKey { get { return KeyItem != null; } }

	public bool CanOpenDoor(List<ItemMaster> items)
	{
		if (!IsNeedKey) return true;
		return items.Contains(KeyItem);
	}
}
