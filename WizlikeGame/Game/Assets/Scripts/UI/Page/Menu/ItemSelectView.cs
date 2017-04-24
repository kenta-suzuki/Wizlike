using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;
using Data.Master;

public class ItemSelectView : MonoBehaviour
{
	[SerializeField]
	CommonButton SubmitButton;
	[SerializeField]
	Text SubmitButtonText;
	[SerializeField]
	Text PriceText;
	[SerializeField]
	Text CurrentPlayerMoney;
	[SerializeField]
	ScrollRect ScrollRect;
	[SerializeField]
	GameObject ContentContainer;
	[SerializeField]
	SelectItemPlate ItemPlate;
	[SerializeField]
	ItemDescriptionPanel DescriptionPanel;
	[SerializeField]
	ItemCountDialog Dialog;

	public event Action SubmitButtonClicked = delegate {};
	public event Action<ItemMaster> PlateSelected = delegate {};
	public event Action<int> CountSelected = delegate {};

	List<SelectItemPlate> plates = new List<SelectItemPlate>();
	ItemSelectModel selectModel;

	public void Initialize()
	{
		Dialog.SubmitButtonClicked += (count) => CountSelected(count);
		SubmitButton.Tapped = () => SubmitButtonClicked();
	}

	public void Refresh()
	{
		PriceText.text = selectModel.Price.ToString();
	}

	public void Show(List<ItemMaster> items, ItemSelectModel model)
	{
		gameObject.SetActive(true);
		var player = GameModel.Instance.Models.Player;
		selectModel = model;
		CurrentPlayerMoney.text = player.Player.Money.ToString();
		items.ForEach(item => CreateItemPlate(item));
	}

	void CreateItemPlate(ItemMaster item)
	{
		var plate = SelectItemPlate.Create(ContentContainer.transform, item);
		plate.PlateButtonClicked += () => PlateSelected(item);
		plates.Add(plate);
	}

	public void SetDescription(ItemMaster master)
	{
		DescriptionPanel.SetDescription(master);
	}

	public void OpenDialog(ItemMaster master)
	{
		Dialog.Open(master, selectModel);
	}

	public void Hide()
	{
		Clear();
		gameObject.SetActive(false);
	}

	public void Clear()
	{
		plates.ForEach(plate => Destroy(plate.gameObject));
		plates.Clear();
	}
}
