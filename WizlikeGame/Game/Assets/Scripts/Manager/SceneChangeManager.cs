using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeManager
{
	public static void Load(string sceneName, bool UseFade = false)
	{
		if (!UseFade)
		{
			Load(sceneName);
			return;
		}

		FadeInOut.Instance.FadeIn(() => Load(sceneName));
	}

	static void Load(string sceneName)
	{
		SceneManager.LoadScene(sceneName);
	}

	public static void LoadAsync(string sceneName)
	{
		SceneManager.LoadSceneAsync(sceneName);
	}
}
