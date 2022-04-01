using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaludPersonaje : MonoBehaviour
{
    public int vidas = 3;

    public static SaludPersonaje instance;

    private void Awake() {
	    instance = this;
    }
}
