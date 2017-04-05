using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public static class LinqExtension 
{

	public static void ForEach<T>(this IEnumerable<T>sequence, Action<T, int> action)
	{
		int index = 0;
		foreach (T item in sequence)
		{
			action(item, index);
			index++;
		}
	}
}
