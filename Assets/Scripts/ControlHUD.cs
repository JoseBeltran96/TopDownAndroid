using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ControlHUD : MonoBehaviour
{
    public float puntos;
    public float vidas;

    public TMP_Text textoPuntos;
    public TMP_Text textoVidas;
    public TMP_Text textoPuntosFinal;
    public GameObject panelDerrota;
    public GameObject Fondo;
    //private controlPublicidad controlPublicidad;

    private void Start()
    {
        textoVidas.text = "x" + vidas.ToString("0");      
    }
    
    public void DarPuntos(float conseguirPuntos)
    {
        puntos += conseguirPuntos;
        textoPuntos.text = puntos.ToString("0");
    }

    public void QuitarVidas(float restarVidas)
    {
      
        vidas -= restarVidas;
        textoVidas.text = "x" + vidas.ToString("0");
        if (vidas <= 0)
        { Time.timeScale = 0;
            panelDerrotaActivar();
            Fondo.SetActive(true);
             
            textoPuntosFinal.text = puntos.ToString("0");
        }
    }

    public void panelDerrotaActivar()
    {
        panelDerrota.SetActive(true);
    }
   
}
