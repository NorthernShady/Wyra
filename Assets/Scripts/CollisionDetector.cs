using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionDetector : MonoBehaviour
{
	void OnCollisionEnter2D(Collision2D coll)
	{
		SceneManager.LoadScene(0);
	}
}
