using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/**
 * Este script foi criado para o objeto commands
 * que e inserido em todos os botoes para dar a funcao de 
 * passar de cenas
 * 
 * */
public class commands : MonoBehaviour {

	/**
	 * funcao que faz a mudanca de cena
	 * */
	public void goTo(string scene){
		SceneManager.LoadScene (scene);
	}


}
