using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndReached : MonoBehaviour
{
	[SerializeField] private GameManager _gm;
	public void OnTriggerEnter2D(Collider2D col)
	{
		if (col.CompareTag("Player"))
		{
			_gm.EndGame();
		}
	}
}
