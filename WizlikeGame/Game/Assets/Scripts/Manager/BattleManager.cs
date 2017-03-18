using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleManager : MonoBehaviour
{
	[SerializeField]
	BattlePageController Controller;

	public static BattleManager Instance { get; private set;}
	bool _isEndTurn;
	List<CharacterBase> _characters;

	void Start ()
	{
		Instance = this;
		_characters = new List<CharacterBase>();
	}

	void SetCharacters()
	{
	}
}
