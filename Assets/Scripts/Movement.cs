using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float velocidad = 5f;
    private Animator animator;
    private float velocidadSuma;

    private Rigidbody2D rb;
    private AudioSource sonido;

    public Joystick joystick;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sonido = GetComponent<AudioSource>();
        Time.timeScale = 1f;
    }

    void Update()
    {
        float x = joystick.Horizontal * velocidad;
        float y = joystick.Vertical * velocidad;
        Vector2 direccion = new Vector2(x, y);
        direccion.Normalize();
        Mover(direccion);

        velocidadSuma = Mathf.Abs(rb.velocity.x) + Mathf.Abs(rb.velocity.y);

        animator.SetFloat("speed", velocidadSuma);

    }

    public void Mover(Vector2 direccion)
    {
        rb.velocity = direccion * velocidad;
    }

    public void atacar()
    {
        sonido.Play();
        animator.SetTrigger("ataque");
    }
    

}
