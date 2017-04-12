using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DangeonPlayerMotor : MonoBehaviour
{
	[SerializeField]
	Animator Animator;
	[SerializeField]
	float Speed;
	[SerializeField]
	float RotSpeed;

	public event Action MoveFinished = delegate {};
	float speedStep = 0;
	float rotStep = 0;
	bool canInput;

	public void Initialize()
	{
		speedStep = Speed * Time.deltaTime;
		rotStep = RotSpeed * Time.deltaTime;
		canInput = true;
	}

	void EnableInput()
	{
		canInput = !canInput;
	}

	public void Move()
	{
		if (!canInput) return;
		canInput = false;
		var target = transform.position + transform.forward * (5);
		StartCoroutine(MoveToTarget(target));
	}

	IEnumerator MoveToTarget(Vector3 target)
	{
		while (Mathf.CeilToInt(Vector3.Distance(transform.position, target)) > 0)
		{
			transform.position = Vector3.MoveTowards(transform.position, target, speedStep);

			yield return null;
		}
		transform.position = target;
		MoveFinished();
		canInput = true;
	}

	public void Rotate(bool isLeft)
	{
		if (!canInput) return;
		canInput = false;

		var rotate = isLeft ? -90 : 90;
		var target = Quaternion.Euler(0, transform.rotation.eulerAngles.y + rotate, 0);
		StartCoroutine(RotateToTarget(target));
	}

	IEnumerator RotateToTarget(Quaternion target)
	{
		while (Mathf.Abs(Mathf.DeltaAngle(transform.eulerAngles.y, target.eulerAngles.y)) > 0.1f)
		{
			transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotStep);
			yield return null;
		}
		transform.rotation = target;
		canInput = true;
	}
}
