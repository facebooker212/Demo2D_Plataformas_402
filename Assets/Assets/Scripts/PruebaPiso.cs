using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PruebaPiso : MonoBehaviour
{
    public static bool estaEnPiso = false;
    
    private void OnTriggerEnter2D(Collider2D collison) {
	estaEnPiso = true;
	print("Esta en piso");
    }
    private void OnTriggerExit2D(Collider2D collison) {
        estaEnPiso = false;
	print("Esta saltando");
    }
}
