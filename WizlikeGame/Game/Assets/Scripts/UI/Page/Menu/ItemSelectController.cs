using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSelectController : MonoBehaviour, IPageController
{
	[SerializeField]
	ItemSelectView View;

	public string Name { get { return ""; } }

	public void Initialize()
	{
	}

	public void Show()
	{
	}

	public void Hide()
	{
	}
}
