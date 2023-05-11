using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private AudioSource sonido;
   
    public float speed = 5f;
    public Vector2 direccion = Vector2.left;
   


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        sonido = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direccion * speed * Time.deltaTime, Space.World);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "espada")
        {
            ControlHUD c = FindObjectOfType<ControlHUD>();
            c.DarPuntos(10);
            StartCoroutine("Muerte");
        }
        if (collision.gameObject.tag == "zonaMuerte")
        {
            ControlHUD c = FindObjectOfType<ControlHUD>();
            c.QuitarVidas(1);
            StartCoroutine("Esfumarse");
        }
    }
    private IEnumerator Muerte()
    {
        sonido.Play();
        animator.SetTrigger("muerte");
        
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
    }
    private IEnumerator Esfumarse()
    {
        sonido.Play();
        animator.SetTrigger("muerte");
      
        yield return new WaitForSeconds(0.3f);
        Destroy(this.gameObject);
    }

}
