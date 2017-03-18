using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Data.Model;

public class Parameter 
{
	public int STR { get; private set;}
	public int INT { get; private set;}
	public int MYS { get; private set;}
	public int AGI { get; private set;}
	public int VIT { get; private set;}
	public int LUC { get; private set;}

	public int PhysicalPower { get; private set;}
	public int PhysicalDefense { get; private set; }
	public int MagicalPower { get; private set; }
	public int MagicalDefense { get; private set; }

	public Parameter(Character character)
	{
		STR = character.Strong;
		INT = character.Intelligence;
		MYS = character.Mystery;
		AGI = character.Agile;
		VIT = character.Vital;
		LUC = character.Luck;
	}
}
