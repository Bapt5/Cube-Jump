using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class The_End : MonoBehaviour {

	public GameObject Bravo;

	void OnCollisionEnter2D (Collision2D col) {
		if (col.gameObject.tag == "Player") {
			Bravo.SetActive (true);
		
		}
	}
}
