using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : MonoBehaviour
{
	public event Action UpArrowTapped = delegate {};
	public event Action DownArrowTapped = delegate {};
	public event Action LeftArrowTapped = delegate {};
	public event Action RightArrowTapped = delegate {};
	public event Action SubmitTapped = delegate {};
	public event Action CancelTapped = delegate {};

	void FixedUpdate()
	{
		if (Input.GetKeyUp(KeyCode.UpArrow))
		{
			UpArrowTapped();
		}
		else if (Input.GetKeyUp(KeyCode.DownArrow))
		{
			DownArrowTapped();
		}
		else if (Input.GetKeyUp(KeyCode.LeftArrow))
		{
			LeftArrowTapped();
		}
		else if (Input.GetKeyUp(KeyCode.RightArrow))
		{
			RightArrowTapped();
		}
		else if (Input.GetKeyUp(KeyCode.KeypadEnter))
		{
			SubmitTapped();
		}
		else if (Input.GetKeyUp(KeyCode.Q))
		{
			CancelTapped();
		}
	}
}
