using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem 
{
	int Id { get; set;}
	int SellPrice { get; set;}
	string Name { get; set;}
	string Description { get; set;}
}
