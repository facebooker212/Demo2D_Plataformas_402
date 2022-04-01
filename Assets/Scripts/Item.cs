using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Victor Martinez Roman
 * Detecta las colisiones con el personaje
 */

public class Item : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider) {
	    if (collider.gameObject.CompareTag("Player")) {
		    gameObject.transform.GetChild(0).gameObject.SetActive(true);
		    //gameObject.transform.GetChild(0) //Es transform de la explosion
		    //gameObject.transform.GetChild(0).gameObject //Explosion
		    GetComponent<SpriteRenderer>().enabled = false;
		    //Destroy(collider.gameObject, 0.3f); //Destruye personaje
		    Destroy(gameObject, 0.3f);
	    }
    }
}

