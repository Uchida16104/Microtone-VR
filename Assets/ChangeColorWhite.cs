using UnityEngine;
using System.Collections;

public class ChangeColorWhite : MonoBehaviour{

	void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Ball"){
			GetComponent<Renderer>().material.color = Color.white;
		}
	}
}