using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Master;
using System.Linq;
using System;

namespace Data.Model
{
	public class Character
	{
		public int Code{ get; private set;}
		public int Lv { get; private set;}
		public string Name { get; private set; }
		public Job Job { get; private set; }
		public int Strong { get; private set; }
		public int Intelligence { get; private set; }
		public int Mystery { get; private set; }
		public int Agile { get; private set; }
		public int Vital { get; private set; }
		public int Luck { get; private set; }

		public List<Equipment> Equipments { get; private set; }
		public List<SkillMaster> Skills { get; private set; }

		public Character(int c, int lv, string name, Job job, int strong, int intelligence, int mystery, int agile, int vital, int luck, List<Equipment> equipments, List<SkillMaster> skills)
		{
			Code = c;
			Lv = lv;
			Name = name;
			Job = job;
			Strong = strong;
			Intelligence = intelligence;
			Mystery = mystery;
			Agile = agile;
			Vital = vital;
			Luck = luck;
			Equipments = equipments;
			Skills = skills;
		}

		public static Character Create(CharacterMaster master, string name, Job job, List<Equipment> equipments = null, List<SkillMaster> skills = null)
		{
			equipments = equipments == null ? new List<Equipment>() : equipments;
			skills = skills == null ? new List<SkillMaster>() : skills;

			var character = new Character(
				GameModel.Instance.Models.Character.Characters.Count + 1,
				1,
				name,
				job,
				master.strong,
				master.intelligence,
				master.mystery,
				master.agile,
				master.vital,
				master.luck,
				equipments,
				skills
			);

			return character;
		}

		static List<T> GetList<T>(string fieldName, JSONObject obj, Func<int, T> func)
		{
			int i = 0;
			List<T> list = new List<T>();
			while (obj.HasField(fieldName + i))
			{
				list.Add(func(i));
				i++;
			}
			return list;
		}

		public static Character Create(string json)
		{
			Debug.Log("Create String " + json);
			return Create(new JSONObject(json));
		}

		static Character Create(JSONObject obj)
		{
			var _equipments = GetList("equipment", obj, (arg) =>
			{
				return GameModel.Instance.Models.Equipment.Equipments.First(e => e.Code == (int)obj.GetField("equipment" + arg).i);
			});

			var _skills = GetList("skill", obj, (arg) =>
			{
				return GameModel.Instance.Masters.Skill.Datas.First(s => s.id == (int)obj.GetField("skill" + arg).i);
			});

			var character = new Character(
				(int)obj.GetField("code").i,
				(int)obj.GetField("lv").i,
				obj.GetField("name").str,
				JobExtension.ToEnum(obj.GetField("job").str),
				(int)obj.GetField("strong").i,
				(int)obj.GetField("intelligence").i,
				(int)obj.GetField("mystery").i,
				(int)obj.GetField("agile").i,
				(int)obj.GetField("vital").i,
				(int)obj.GetField("luck").i,
				_equipments,
				_skills
			);

			return character;
		}

		void SetField(string fieldName, JSONObject json, List<int> list)
		{
			for (int i = 0; i < list.Count; i++)
			{
				json.SetField(fieldName + i, list[i]);
			}
		}

		public JSONObject ToJson()
		{
			var json = new JSONObject();
			json.SetField("code", Code);
			json.SetField("lv", Lv);
			json.SetField("name", Name);
			json.SetField("job", Job.ToString());
			json.SetField("strong", Strong);
			json.SetField("intelligence", Intelligence);
			json.SetField("mystery", Mystery);
			json.SetField("agile", Agile);
			json.SetField("vital", Vital);
			json.SetField("luck", Luck);
			SetField("equipment", json, Equipments.Select(e => e.Code).ToList());
			SetField("skill", json, Skills.Select(s => s.id).ToList());

			return json;
		}

		public void Equip(Equipment equipment)
		{
			Equipments.Add(equipment);
		}

		public void RemoveEquip(Equipment equipment)
		{
			Equipments.Remove(equipment);
		}

		public override string ToString()
		{
			return ToJson().ToString();
		}
	}
}