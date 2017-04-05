using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IPageController
{
	string Name { get; }
	void Initialize();
	void Show();
	void Hide();
}
