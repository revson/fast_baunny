using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class moveFrame : MonoBehaviour {
	private GameController _GameController;
	private Rigidbody2D rbFrame;

	private bool instantiating;


	// Use this for initialization
	void Start () {
		// instancia o game controller
		_GameController = FindObjectOfType (typeof(GameController)) as GameController;

		rbFrame = GetComponent<Rigidbody2D> ();
		rbFrame.velocity = new Vector2 (_GameController.speedObject, 0);

	}
	
	// Update is called once per frame
	void Update () {

		if(instantiating == false){
			if(transform.position.x <= 0){
				instantiating = true;

				int idPrefab = 0;
				int rand = Random.Range (0,100);

				if (rand < 33) {
					idPrefab = 0;
				} else if (rand > 33 && rand < 66) {
					idPrefab = 1;
				}else if(rand > 66) {
					idPrefab = 2;
				}
				GameObject temp = Instantiate (_GameController.framePrefab[idPrefab]);
				float posX = transform.position.x + _GameController.frameSize;
				float posY = transform.position.y;
				temp.transform.position = new Vector3 (posX, posY, 0);
			}
		}

		if(transform.position.x < _GameController.distanceDestroy){

			Destroy (this.gameObject);

		}

	}
}
