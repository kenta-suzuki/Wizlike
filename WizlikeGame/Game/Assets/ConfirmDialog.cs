using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class ConfirmDialog : MonoBehaviour
{
	const string path = "";

	[SerializeField]
	Text Title;
	[SerializeField]
	Text Message;
	[SerializeField]
	Button OKButton;
	[SerializeField]
	Button NGButton;
	[SerializeField]
	Animator DialogAnimator;

	public static void CreateDialog(Transform parent, string title, string message, Action okButtonClicked, Action ngButtonClicked = null)
	{
		var obj = (GameObject)Instantiate(Resources.Load(path), Vector3.zero, Quaternion.identity);
		obj.transform.SetParent(parent);
		var instance = obj.GetComponent<ConfirmDialog>();
		instance.SetParameters(title, message, okButtonClicked, ngButtonClicked);
	}

	void SetParameters(string title, string message, Action okButtonClicked, Action ngButtonClicked)
	{
		Title.text = title;
		Message.text = message;
		OKButton.onClick.AddListener(() => okButtonClicked());
		NGButton.onClick.AddListener(() =>
		{
			if(ngButtonClicked != null) ngButtonClicked();
			Close();
		});
	}

	void Close()
	{
		DialogAnimator.SetBool("IsClose", true);
	}
}
