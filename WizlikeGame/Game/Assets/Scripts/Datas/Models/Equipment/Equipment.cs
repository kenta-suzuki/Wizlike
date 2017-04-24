using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;

namespace Data.Model
{
	public class Equipment : IItem
	{
		public int Id { get; set; }
		public int SellPrice { get; set; }
		public string Name { get; set; }
		public string Description { get; set;}

		public string NotFoundName { get; set; }
		public int Code { get; private set;}
		public int Lv { get; private set; }
		public int Power { get; private set; }
		public int Deffense { get; private set; }
		public int Avoidance { get; private set; }
		public int Hit { get; private set; }
		public Attribute Attribute { get; private set; }
		public EnemyTribe RegistTribe { get; private set; }

		public Equipment(int id, string description, int sellPrice, int code, int lv, string name, string notFoundName, int power, int deffense, int avoidance, int hit, Attribute attribute, EnemyTribe tribe)
		{
			Id = id;
			Name = name;
			SellPrice = sellPrice;
			Description = description;
			NotFoundName = notFoundName;
			Code = code;
			Lv = lv;
			Power = power;
			Deffense = deffense;
			Avoidance = avoidance;
			Hit = hit;
			Attribute = attribute;
			RegistTribe = tribe;
		}

		public static Equipment Create(EquipmentMaster master)
		{
			var equipment = new Equipment(
				master.id,
				"description",
				100,
				GameModel.Instance.Models.Equipment.Equipments.Count + 1,
				1,
				master.name,
				master.not_found_name,
				master.power,
				master.deffense,
				master.avoidance,
				master.hit,
				master.attribute,
				master.regist_tribe
			);

			return equipment;
		}

		static Equipment Create(JSONObject obj)
		{
			var equipment = new Equipment(
				(int)obj.GetField("id").i,
				obj.GetField("description").str,
				(int)obj.GetField("sell_price").i,
				(int)obj.GetField("code").i,
				(int)obj.GetField("lv").i,
				obj.GetField("name").str,
				obj.GetField("not_found_name").str,
				(int)obj.GetField("power").i,
				(int)obj.GetField("deffense").i,
				(int)obj.GetField("avoidance").i,
				(int)obj.GetField("hit").i,
				AttributeExtension.ToEnum( obj.GetField("attribute").str),
				EnemyTribeExtension.ToEnum( obj.GetField("regist_tribe").str)
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
			json.SetField("id", Id);
			json.SetField("description", Description);
			json.SetField("sell_price", SellPrice);
			json.SetField("code", Code);
			json.SetField("lv", Lv);
			json.SetField("name", Name);
			json.SetField("not_found_name", NotFoundName);
			json.SetField("power", Power);
			json.SetField("deffense", Deffense);
			json.SetField("avoidance", Avoidance);
			json.SetField("hit", Hit);
			json.SetField("attribute", Attribute.ToString());
			json.SetField("regist_tribe", RegistTribe.ToString());

			return json;
		}

		public override string ToString()
		{
			return ToJson().ToString();
		}
	}
}