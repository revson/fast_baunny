using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

	private bannyController _bannyController;

	//label de indicacao
	[Header("config. Objetos")]

	public float speedObject;
	public float distanceDestroy;
	public float frameSize;
	public GameObject[] framePrefab;



	[Header("Globals")]

	public int score;

	public Text txtScore;

	public float posXPlayer;

	[Header("FX Sound")]

	public AudioSource fxSource;
	public AudioClip fxPoints;

	// Use this for initialization
	void Start () {

		_bannyController = FindObjectOfType (typeof(bannyController)) as bannyController;

	}


	public void setPoints(int points){
		score += points;
		txtScore.text ="Score " + score.ToString();
		fxSource.PlayOneShot (fxPoints);
	}

	public void goTo(string scene){
		SceneManager.LoadScene (scene);
	}



}
