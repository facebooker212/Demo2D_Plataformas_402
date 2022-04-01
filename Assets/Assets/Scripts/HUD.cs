using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{
    public static HUD instance;

    public Image Image1;
    public Image Image2;
    public Image Image3;

    private void Awake() {
	    instance = this;
    }

    //Debe conectarse al boton "Resume"
    public void Reanudar()
    {
	    MenuPausa.instance.Pausar();
    }

    public void ActualizarVidas() {
	    int vidas = SaludPersonaje.instance.vidas;
	    switch (vidas) {
		    case 0:
			Image1.enabled = false;
			break;
		    case 1:
			Image2.enabled = false;
			break;
		    case 2:
			Image3.enabled = false;
			break;
	    }
    }
}
