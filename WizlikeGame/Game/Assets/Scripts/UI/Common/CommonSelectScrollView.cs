using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonSelectScrollView : MonoBehaviour
{
	[SerializeField]
	GameObject Root;
	[SerializeField]
	Transform ContentParent;

	List<SelectContent> _contents;

	public void Show()
	{
	}

	public void Hide()
	{
		Clear();
		Root.SetActive(false);
	}

	public void Clear()
	{
	}
}
