using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using Data.Master;

public class ItemCountDialog : MonoBehaviour
{
	[SerializeField]
	Text ItemName;
	[SerializeField]
	Text Count;
	[SerializeField]
	CommonButton SubmitButton;
	[SerializeField]
	CommonButton UpButton;
	[SerializeField]
	CommonButton DownButton;

	int count;
	public event Action<int> SubmitButtonClicked = delegate {};

	public void Open(ItemMaster master, ItemSelectModel model)
	{
		ItemName.text = master.name;
		count = model.GetItemCount(master);
		Count.text = count.ToString();
		SubmitButton.Tapped = () => SubmitButtonClicked(count);
		UpButton.Tapped = () => OnCountEditButtonClick(1);
		DownButton.Tapped = () => OnCountEditButtonClick(-1);
	}

	void OnCountEditButtonClick(int editCount)
	{
		count += editCount;
	}
}
