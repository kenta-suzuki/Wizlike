using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Data.Master;
using System;

public class SelectItemPlate : MonoBehaviour
{
	[SerializeField]
	Text Name;
	[SerializeField]
	Text Price;
	[SerializeField]
	CommonButton PlateButton;

	const string path = "";

	public event Action PlateButtonClicked = delegate {};

	public void SetItem(ItemMaster master)
	{
		Name.text = master.name;
		Price.text = master.price.ToString();
	}

	public static SelectItemPlate Create(Transform parent, ItemMaster master)
	{
		var obj = (GameObject)Instantiate(Resources.Load(path), Vector3.zero, Quaternion.identity);
		obj.transform.SetParent(parent);
		var plate = obj.GetComponent<SelectItemPlate>();
		plate.SetItem(master);

		return plate;
	}
}
