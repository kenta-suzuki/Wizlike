using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;

namespace Data.Model
{
	public class Item : IItem
	{
		public int Id { get; set; }
		public int Code { get; set; }
		public string Name { get;  set; }
		public string NotFoundName { get; private set; }
		public string Description { get; set; }
		public int SellPrice { get; set; }
		public bool IsAppraisal { get; private set; }

		public Item(int i, int c, string n, string nfn, string d, int sp, bool ia)
		{
			Id = i;
			Code = c;
			Name = n;
			NotFoundName = nfn;
			Description = d;
			SellPrice = sp;
			IsAppraisal = ia;
		}

		public static Item Create(ItemMaster master, bool ia)
		{
			var item = new Item(
				master.id,
				GameModel.Instance.Models.Item.Items.Count + 1,
				master.name,
				master.not_found_name,
				master.description,
				master.sell_price,
				ia
			);

			return item;
		}

		static Item Create(JSONObject obj)
		{
			var item = new Item(
				(int)obj.GetField("id").i,
				(int)obj.GetField("code").i,
				obj.GetField("name").str,
				obj.GetField("not_found_name").str,
				obj.GetField("description").str,
				(int)obj.GetField("sell_price").i,
				obj.GetField("is_appraisal").b
			);

			return item;
		}

		public static Item Create(string json)
		{
			Debug.Log("Create String " + json);
			return Create(new JSONObject(json));
		}

		JSONObject ToJson()
		{
			var json = new JSONObject();
			json.SetField("item_id", Id);
			json.SetField("code", Code);
			json.SetField("name", Name);
			json.SetField("not_found_name", NotFoundName);
			json.SetField("description", Description);
			json.SetField("sell_price", SellPrice);
			json.SetField("is_appraisal", IsAppraisal);

			return json;
		}

		public override string ToString()
		{
			return ToJson().ToString();
		}
	}
}
