using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterControl : MonoBehaviour {

	private Rigidbody2D rb;
	int coins = 0;
	public Text contadorCoins; 

	// Use this for initialization
	void Start () {
		
		rb = GetComponent <Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (KeyCode.RightArrow)) {
			this.transform.Translate (0.02f, 0f, 0f);

		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			this.transform.Translate (-0.02f, 0f, 0f);

		}

		if (Input.GetKeyDown (KeyCode.Space)) {
			rb.AddForce (Vector2.up * 4, ForceMode2D.Impulse); 

		}
	}

	void OnTriggerEnter2D(Collider2D coll) {
		if (coll.gameObject.tag == "Coins") { //Detectamos colision solo con monedas
			// aumentar la cantidad de monedas
			coins = coins + 1;
			// mostramos la cantidad de monedas usando el componente Text
			contadorCoins.text = coins.ToString();

			//Destruimos la moneda
			GameObject.Destroy (coll.gameObject);

		}
	}
}
