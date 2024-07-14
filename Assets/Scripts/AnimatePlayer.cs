using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum AnimationType
{
	Idle,
	Run,
	Jump,
	LedgeGrab
}

public class AnimatePlayer : MonoBehaviour
{
	[SerializeField] private Animator _animator;

	public void Animate(AnimationType type)
	{
		switch (type)
		{
			case AnimationType.Idle:
				_animator.Play("idle outline_Clip");
				break;
			case AnimationType.Run:
				_animator.Play("run outline_Clip");
				break;
			case AnimationType.Jump:
				_animator.Play("full jump animation outline_Clip");
				break;
			case AnimationType.LedgeGrab:
				_animator.Play("ledge grab outline_Clip");
				break;
			default:
				throw new ArgumentOutOfRangeException(nameof(type), type, null);
		}
	}
}
