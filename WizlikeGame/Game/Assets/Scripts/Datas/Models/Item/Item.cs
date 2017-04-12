using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;

namespace Data.Model
{
	public class Item 
	{
		public int code { get; private set; }
		public string name { get; private set; }


		public Item(int c, string n)
		{
			code = c;
			name = n;
		
		}

		public static Item Create(ItemMaster master)
		{
			var item = new Item(
				GameModel.Instance.Models.Item.Items.Count + 1,
				master.name
			);

			return item;
		}

		static Item Create(JSONObject obj)
		{
			var item = new Item(
				(int)obj.GetField("code").i,
				obj.GetField("name").str
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
			json.SetField("code", code);
			json.SetField("name", name);

			return json;
		}

		public override string ToString()
		{
			return ToJson().ToString();
		}
	}
}
