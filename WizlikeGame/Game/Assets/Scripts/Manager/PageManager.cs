﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class PageManager : MonoBehaviour
{
	static PageManager _instance;
	public static PageManager Insatance
	{
		get
		{
			return _instance;
		}
	}

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
		_instance = GetComponent<PageManager>();
		LoadPageController();
	}

	void LoadPageController()
	{
		Controllers = GetComponentsInChildren<IPageController>().ToList();
		Controllers.ForEach(c => c.Initialize());
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
