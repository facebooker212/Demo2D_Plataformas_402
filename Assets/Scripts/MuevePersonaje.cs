using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuevePersonaje : MonoBehaviour
{
    public float velocidadX;
    public float velocidadY;

    private Rigidbody2D rb;

    private Animator animator;

    private SpriteRenderer rendererPersonaje;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
	animator = GetComponent<Animator>();
	rendererPersonaje = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        float movVertical = Input.GetAxis("Vertical");
        if (movVertical>0)
        {
            rb.velocity = new Vector2(rb.velocity.x, movVertical * velocidadY);
        }
        float movHorizontal = Input.GetAxis("Horizontal");
	rb.velocity = new Vector2(movHorizontal * velocidadX, rb.velocity.y);
    	
	animator.SetBool("speed", movHorizontal != 0.0f);
	rendererPersonaje.flipX = rb.velocity.x < 0;
    }
}
