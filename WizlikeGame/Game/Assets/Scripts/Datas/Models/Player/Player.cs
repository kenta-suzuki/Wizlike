using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Data.Model
{
	public class Player
	{
		public int Money { get; private set; }
		public List<Character> Party { get; private set;}

		public Player(int moeny)
		{
			Money = moeny;
		}

		JSONObject ToJson()
		{
			var json = new JSONObject();
			json.SetField("money", Money);
			return json;
		}

		static Player Create(JSONObject json)
		{
			var player = new Player((int)json.GetField("money").i);
			return player;
		}

		public static Player Create(string json)
		{
			Debug.Log("Create String " + json);
			return Create(new JSONObject(json));
		}

		public void AddMoney(int add)
		{
			Money += add;
		}

		public void DelMoney(int del)
		{
			if (CanReduce(del))
			{
				Money -= del;
			}
		}

		bool CanReduce(int del)
		{
			var temp = Money - del;
			return temp > 0;
		}

		public override string ToString()
		{
			return ToJson().ToString();
		}
	}
}