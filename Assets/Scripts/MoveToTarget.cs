using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
	[SerializeField]
	private Transform target;

	// Update is called once per frame
	void Update ()
	{
		var position = transform.position;
		position.x = target.position.x;
		transform.position = position;
	}
}
