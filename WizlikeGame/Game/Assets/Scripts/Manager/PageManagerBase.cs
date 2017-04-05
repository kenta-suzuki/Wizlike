using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public abstract class PageManagerBase : MonoBehaviour
{
	static PageManagerBase _instance;
	public static PageManagerBase Insatance
	{
		get
		{
			return _instance;
		}
	}

	[SerializeField]
	List<IPageController> controllers;

	void Start()
	{
		Initialize();
		controllers.First((c) => c.IsDefaultPage).Show();
	}

	public void Initialize()
	{
		_instance = GetComponent<PageManagerBase>();
	}

	public void ShowPage(string name)
	{
		controllers.ForEach(c => c.Hide());
		var controller = controllers.FirstOrDefault((c) => c.Name == name);
		if (controller != null)
		{
			controller.Show();
		}
	}

	public void HidePage(string name)
	{
		var controller = controllers.FirstOrDefault(c => c.Name == name);
		if (controller != null)
		{
			controller.Hide();
		}
	}
}
