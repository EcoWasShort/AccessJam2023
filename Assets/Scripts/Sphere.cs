using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
	//viene richiamato ogni volta che collide con un'altro Collider
	void OnCollision(Collision collision){
		Debug.Log("Ho Colliso con: " + collision.gameObject.name);
	}
}