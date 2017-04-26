using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
	[SerializeField]
	private GameObject prefab;

	[SerializeField]
	private Vector2 offset = Vector2.right;

	// Use this for initialization
	void Start ()
	{
		create(transform.position + (Vector3)offset);
	}

	void HandleAction(TriggerEvent obj)
	{
		obj.triggered -= HandleAction;
		create(obj.transform.position + (Vector3)offset);
	}

	public void create(Vector2 position)
	{
		var obstacle = Instantiate(prefab, position, Quaternion.identity) as GameObject;
		obstacle.SetActive(true);

		var t = obstacle.GetComponent<TriggerEvent>();
		t.triggered += HandleAction;
	}
}
