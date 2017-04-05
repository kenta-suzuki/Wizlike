using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PageManager : MonoBehaviour
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
	List<IPageController> Controllers;
	[SerializeField]
	string DefaultPageName;

	void Start()
	{
		Initialize();
		ShowPage(DefaultPageName);
	}

	public void Initialize()
	{
		_instance = GetComponent<PageManagerBase>();
	}

	public void ShowPage(string name)
	{
		Controllers.ForEach(c => c.Hide());
		var controller = Controllers.FirstOrDefault((c) => c.Name == name);
		if (controller != null)
		{
			controller.Show();
		}
	}

	public void HidePage(string name)
	{
		var controller = Controllers.FirstOrDefault(c => c.Name == name);
		if (controller != null)
		{
			controller.Hide();
		}
	}
}
