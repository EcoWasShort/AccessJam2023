using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
	//Viene chiamato ogni volta che un collider entra nel collider Trigger
	//Esistono variazioni, come OnTriggerExit, OnTriggerStay
	void OnTriggerEnter(Collider other){
		Debug.Log("è entrato : " + other.gameObject.name); //Dice al log cercando il nome dell'oggetto che è entrato
	}

	void OnTriggerStay(Collider other){
		Debug.Log("è ancora stanzionato : " + other.gameObject.name);
	}

	void OnTriggerExit(Collider other){
		Debug.Log("è uscito : " + other.gameObject.name);
	}
}
