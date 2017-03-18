using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CommonInfoView 
{
	[SerializeField]
	Text Message;

	public void UpdateMessage(string message)
	{
		Message.text = message;
	}
}
