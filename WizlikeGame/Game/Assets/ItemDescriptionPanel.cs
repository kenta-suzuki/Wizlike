using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Data.Master;

public class ItemDescriptionPanel : MonoBehaviour
{
	[SerializeField]
	Text Name;
	[SerializeField]
	Text Description;

	public void SetDescription(ItemMaster master)
	{
		Name.text = master.name;
		Description.text = master.description;
	}
}
