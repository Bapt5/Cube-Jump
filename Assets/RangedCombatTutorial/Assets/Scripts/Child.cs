using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Child : MonoBehaviour {

	public Text text;
	public int number;

	void Update (){
		number = Mathf.Clamp (number, 0, 3);
		text.text = "Children : " + number + "/3";
	}

	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Child") {
			number += 1;
			Destroy (col.gameObject);
		}
	}
}
