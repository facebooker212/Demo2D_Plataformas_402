using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //Se ejecuta al dar click sobre el boton
    public void Jugar()
    {
	    SceneManager.LoadScene("EscenaMapa");
    }
}
