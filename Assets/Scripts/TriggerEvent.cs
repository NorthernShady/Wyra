using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TriggerEvent : MonoBehaviour
{
	public event Action<TriggerEvent> triggered;

	void OnTriggerEnter2D(Collider2D other)
	{
		var t = triggered;
		if (t != null)
			triggered(this);

		Debug.Log("Triggered");
	}
}
