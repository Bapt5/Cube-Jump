using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private Rigidbody2D rb;
    private Animator anim;

    public float speed;
	public float jumpForce;
	private float moveInput;
	private bool facingRight = true;

	private int extraJumps;
	public int extraJumpsValue;

	private float jumpInput;
	private bool isGrounded;
	public Transform groundCheck;
	public float checkRadius;
	public LayerMask whatIsGround;

    //J'assigne la variable d'animation et celle du Rigidbody2D
	private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }
		

    private void Update()
    {
		//Variable moveInput pour l'axis Horizontale
		moveInput = Input.GetAxis ("Horizontal");
		//faire avancer le personnage ne fonction de move Input
		rb.velocity = new Vector2 (moveInput * speed, rb.velocity.y);
		//Variable jumpInput pour l'axis Jump
		jumpInput = Input.GetAxis ("Jump");

		//Animation de course 
		if (moveInput>0 || moveInput<0) {
			anim.SetBool("isRunning", true);
		}

		if (moveInput==0) {
			anim.SetBool("isRunning", false);
		}
			
		//Si le personnage est au sol mettre la variable active de saut supplémentaire à la valeur autorisé
		if (isGrounded == true) {
			extraJumps = extraJumpsValue;
		}

		//Faire des sauts supplémentaires au joueur
		if (jumpInput>0 && extraJumps > 0){
			rb.velocity = Vector2.up * jumpForce;
			extraJumps = extraJumps-1;
			anim.SetBool("isJumping", true);
		}

		//Faire sauter le personnage pour la 1e fois 
		if (jumpInput>0 && extraJumps == 0 && isGrounded == true){
			rb.velocity = Vector2.up * jumpForce;
			anim.SetBool("isJumping", true);
		}

		//Stopper l'animation de saut
		if (isGrounded == true && jumpInput==0){
			anim.SetBool("isJumping", false);
		}

    }

    private void FixedUpdate(){
		//Retourner le joueur quand il le faut du bon coté
		if (facingRight == false && moveInput > 0) {
			Flip ();
		} else if (facingRight == true && moveInput < 0) {
			Flip ();
		}

		//J'assigne la variable isGrounded à la position des pieds du joueur
		isGrounded = Physics2D.OverlapCircle (groundCheck.position, checkRadius, whatIsGround);

    }

	//Retourner le joueur
	void Flip () 
	{

		facingRight = !facingRight;
		Vector3 Scaler = transform.localScale;
		Scaler.x *= -1;
		transform.localScale = Scaler;

	}
}
