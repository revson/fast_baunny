using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * Este escript tem como finalidade fazer o movimento
 * do background atraves de configuracoe e funcoes
 * que farao o backgound se movimentar com efeito 
 * paralax 
 **/
public class MoveOffSet : MonoBehaviour {

	//variavel que armazenara o mesh renderer
	private MeshRenderer mrMeshRenderer;

	//variavel que armazenara o material
	private Material mtCurrentMaterial;

	// variavel que vai incrementar o off set do material
	public float increase;

	//variavel de setar a velocidade do movimento
	public float speed;

	//variavel escolha da layer
	public string sortInLayer;

	//variavel de setar a ordem do objeto na layer
	public int orderInLayer;

	//variavel recebera o valor do offSet
	private float offSet;



	// Use this for initialization
	void Start () {

		//acessando o componente mesh renderer
		mrMeshRenderer = GetComponent<MeshRenderer>();

		//setando a sort in layer
		mrMeshRenderer.sortingLayerName = sortInLayer;

		//setando a ordem do objeto dentro da layer
		mrMeshRenderer.sortingOrder = orderInLayer;

		// recuperando o material corrente
		mtCurrentMaterial = mrMeshRenderer.material;




	}
	
	// Update is called once per frame
	void Update () {

		/**
		 * O offSet e uma propriedade do Material
		 * que faz ele griar nos seus eixos
		 * iniciando sempre no valor 0
		 * Para termos o movimento, colocamos o velor
		 * do incremento em 0.001 e multiplicamos pela
		 * velocidade.
		 * Depois so ir regulando conforme a necessidade.
		 * 
		 * */

		//setando o velor do offSet por update
		offSet += increase * speed;


		//Fazendo o movimento no material usando o offSet * a velocidade
		mtCurrentMaterial.SetTextureOffset("_MainTex", new Vector2(offSet, 0));
		
	}
}
