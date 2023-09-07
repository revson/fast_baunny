using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bannyController : MonoBehaviour {

	private GameController _gameController;
	private Rigidbody2D playerRb;
	public Transform checkGrounded;

	private bool isGrounded;
	public float jumpForce;


	// Use this for initialization
	void Start () {
		_gameController = FindObjectOfType (typeof(GameController)) as GameController;
		playerRb = GetComponent<Rigidbody2D> ();
		
	}

	void FixedUpdate(){
		isGrounded = Physics2D.OverlapCircle (checkGrounded.position, 0.02f);

	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetButtonDown("Jump") && isGrounded  == true){

			playerRb.AddForce (new Vector2(0, jumpForce));
		}
	}

	void OnTriggerEnter2D(Collider2D col){

		switch(col.gameObject.tag){

		case "colects":
			
			_gameController.setPoints (1);
			Destroy (col.gameObject);
			break;

		case "obstacles":
			_gameController.goTo ("gameOver");
			break;

		}

	}
}
