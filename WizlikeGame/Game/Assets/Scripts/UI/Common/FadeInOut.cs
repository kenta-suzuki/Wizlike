using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class FadeInOut : MonoBehaviour
{
	[SerializeField]
	Image BG;
	[SerializeField]
	byte amount;

	const string PrefabPath = "Prefabs/UI/Fade";

	static FadeInOut _instance;
	public static FadeInOut Instance { get { return _instance; } }

	void Start()
	{
		_instance = this;
		gameObject.SetActive(false);
		Application.DontDestroyOnLoad(transform.parent);
	}

	public void FadeIn(Action callback)
	{
		gameObject.SetActive(true);
		StartCoroutine(WaitForFadeIn(callback));
	}

	IEnumerator WaitForFadeIn(Action callback)
	{
		byte alpha = 0;
		while (BG.color.a < 1)
		{
			alpha += amount;
			BG.color = new Color32(0, 0, 0, alpha);
			yield return null;
		}

		callback();
		yield return new WaitForSeconds(0.3f);
		FadeOut();
	}

	void FadeOut()
	{
		StartCoroutine(WaitForFadeOut());
	}

	IEnumerator WaitForFadeOut()
	{
		byte alpha = 255;
		while (BG.color.a > 0)
		{
			alpha -= amount;
			BG.color = new Color32(0, 0, 0, alpha);
			yield return null;
		}
		gameObject.SetActive(false);
	}
}
