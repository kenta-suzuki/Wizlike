using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;

namespace Data.Model
{
	public class Equipment
	{
		public int code { get; private set;}
		public int lv { get; private set; }
		public string name { get; private set; }
		public int strong { get; private set; }
		public int intelligence { get; private set; }
		public int mystery { get; private set; }
		public int agile { get; private set; }
		public int vital { get; private set; }
		public int luck { get; private set; }
		public int accuracy { get; private set; }
		public int physical_power { get; private set; }
		public int physical_defense { get; private set; }
		public int magical_power { get; private set; }
		public int magical_defense { get; private set; }
		public Attribute attribute { get; private set; }
		public Tribe regist_tribe_1 { get; private set; }
		public Tribe regist_tribe_2 { get; private set; }
		public Tribe regist_tribe_3 { get; private set; }

		public Equipment(int c, int level, string n, int s, int i, int m, int a, int v, int l, Attribute attri, Tribe rt1, Tribe rt2, Tribe rt3)
		{
			code = c;
			lv = level;
			name = n;
			strong = s;
			intelligence = i;
			mystery = m;
			agile = a;
			vital = v;
			luck = l;
			attribute = attri;
			regist_tribe_1 = rt1;
			regist_tribe_2 = rt2;
			regist_tribe_3 = rt3;
		}

		public static Equipment Create(EquipmentMaster master)
		{
			var equipment = new Equipment(
				GameModel.Instance.Models.Equipment.Equipments.Count + 1,
				1,
				master.name,
				master.strong,
				master.intelligence,
				master.mystery,
				master.agile,
				master.vital,
				master.luck,
				master.attribute,
				master.regist_tribe_1,
				master.regist_tribe_2,
				master.regist_tribe_3
			);

			return equipment;
		}

		static Equipment Create(JSONObject obj)
		{
			var equipment = new Equipment(
				(int)obj.GetField("code").i,
				(int)obj.GetField("lv").i,
				obj.GetField("name").str,
				(int)obj.GetField("strong").i,
				(int)obj.GetField("intelligence").i,
				(int)obj.GetField("mystery").i,
				(int)obj.GetField("agile").i,
				(int)obj.GetField("vital").i,
				(int)obj.GetField("luck").i,
				AttributeExtension.ToEnum( obj.GetField("attribute").str),
				TribeExtension.ToEnum( obj.GetField("regist_tribe_1").str),
				TribeExtension.ToEnum( obj.GetField("regist_tribe_2").str),
				TribeExtension.ToEnum( obj.GetField("regist_tribe_3").str)
			);

			return equipment;
		}

		public static Equipment Create(string json)
		{
			Debug.Log("Create String " + json);
			return Create(new JSONObject(json));
		}

		JSONObject ToJson()
		{
			var json = new JSONObject();
			json.SetField("code", code);
			json.SetField("lv", lv);
			json.SetField("name", name);
			json.SetField("strong", strong);
			json.SetField("intelligence", intelligence);
			json.SetField("mystery", mystery);
			json.SetField("agile", agile);
			json.SetField("vital", vital);
			json.SetField("luck", luck);
			json.SetField("attribute", attribute.ToString());
			json.SetField("regist_tribe_1", regist_tribe_1.ToString());
			json.SetField("regist_tribe_2", regist_tribe_2.ToString());
			json.SetField("regist_tribe_3", regist_tribe_3.ToString());

			return json;
		}

		public override string ToString()
		{
			return ToJson().ToString();
		}
	}
}