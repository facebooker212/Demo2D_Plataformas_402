using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
 * Autor: Victor Martinez Roman A-1746361
 * Comportamiento del menu pausa. Pausar y reanudar.
 */

public class MenuPausa : MonoBehaviour
{
	[SerializeField] //Para acceder desde unity como privado
	private GameObject panelPausa;
	public bool estaPausado = false;

	public static MenuPausa instance;

	private void Awake()
	{
		instance = this;
	}

	public void Pausar()
	{
		estaPausado = !estaPausado;
		panelPausa.SetActive(estaPausado);
		Time.timeScale = estaPausado ? 0 : 1;
	}

	private void FixedUpdate()
	{
		if (Input.GetKey(KeyCode.Escape))
		{
			Pausar();
		}
	}
}
