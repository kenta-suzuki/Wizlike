using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartyView : MonoBehaviour
{
	[SerializeField]
	List<Transform> FacePositions;

	const int CurrentFaceDistance = 10;
	int _currentIndex;
	List<CommonCharacterFace> _faces;

	public void Initialize()
	{
	}
}
