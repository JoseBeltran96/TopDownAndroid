using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menus : MonoBehaviour
{

    public GameObject menuPausa;
    public GameObject menuFinal;
    private controlPublicidad controlPublicidad;

    private void Start()
    {
        controlPublicidad = gameObject.GetComponent<controlPublicidad>();
    }

    public void BotonJugar()
    {

        SceneManager.LoadScene("SampleScene");
    }
    public void BotonSalir()
    {
        Application.Quit();
    }
   
    public void BotonMenu()
    {        SceneManager.LoadScene("MenuPrincipal");
    }

    public void BotonRestart()
    {
        controlPublicidad.mostrarPublicidad();
    }

    public void BotonContinuar()
    {
        Time.timeScale = 1f;
        menuPausa.SetActive(false);

    
    }
    public void BotonMenuPausa()
    {

        Time.timeScale = 0f;

    }
}
