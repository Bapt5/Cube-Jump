using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

	public string Level;

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Player") {
			Application.LoadLevel (Level);
		}
	}

}
