using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health: MonoBehaviour {

	public float maxHealth = 3;
	public float health;
	public string Level;

	public Image Coeur;
	public Text Surplus;

	void Start () {
		health = maxHealth;

	}

	void Update () {
		if (health == 3) {
			Coeur.fillAmount = 1;
		}

		if (health == 2) {
			Coeur.fillAmount = 0.675f;
		}

		if (health == 1) {
			Coeur.fillAmount = 0.331f;
		}

		if (health == 0) {
			Coeur.fillAmount = 0;
			Application.LoadLevel (Level);
		}

		if (health > 3) {
			Surplus.text = "+" + (health - 3);
		
		}

		if (health <=3) {
			Surplus.text = "";

		}
	}
		
	void OnCollisionEnter2D (Collision2D col){
		if (col.gameObject.tag == "Enemy") {
			health -= 1;
		}
	}
}
