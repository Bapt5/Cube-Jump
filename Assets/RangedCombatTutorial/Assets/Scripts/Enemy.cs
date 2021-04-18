using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Enemy : MonoBehaviour {

    public Animator camAnim;
	public float maxHealth;
	private float health;
    public GameObject deathEffect;
    public GameObject explosion;

	public Image Barre;

	void Start () {
		health = maxHealth;
	}

    private void Update()
    {
        if (health <= 0) {
            Instantiate(deathEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

		Barre.fillAmount = health/maxHealth;
    }

    public void TakeDamage(int damage) {
        camAnim.SetTrigger("shake");
        Instantiate(explosion, transform.position, Quaternion.identity);
        health -= damage;
    }
}
