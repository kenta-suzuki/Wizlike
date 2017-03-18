using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using Data.Model;
using Data.Master;

public static class JSONObjectExtension
{
	public static string ToJsonString(this List<string> values)
	{
		var str = "";
		for (int i = 0; i < values.Count; i++)
		{
			str += values[i];
			if (i + 1 < values.Count) str += ";";
		}
		return str;
	}

	public static List<string> ToStringList(string str)
	{
		return str.Split(';').Select(e => e).ToList();
	}
}
