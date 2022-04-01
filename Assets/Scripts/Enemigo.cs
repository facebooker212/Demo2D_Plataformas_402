using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour {
	
	private void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.CompareTag("Player")) {
			//Destroy(other.gameObject, 0.3f);
			SaludPersonaje.instance.vidas--;
			HUD.instance.ActualizarVidas();
			if (SaludPersonaje.instance.vidas == 0) {
				Destroy(other.gameObject);
			}
		}
	}
}
