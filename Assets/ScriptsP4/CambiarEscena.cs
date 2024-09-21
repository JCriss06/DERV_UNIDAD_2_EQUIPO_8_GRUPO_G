using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambiarEscena : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI txtResultado;

    void Update()
    {
        int escena = SceneManager.GetActiveScene().buildIndex;
        
        if (escena == 0 && Input.GetKeyDown(KeyCode.Space))
        {
            cambioEscena(1);
        }
        else if (escena == 1 && Input.GetKeyDown(KeyCode.Space))
        {
            cambioEscena(2);
        }
        else if (escena == 3)
        {
            txtResultado.text = PlayerPrefs.GetString("Resultado", "");
        }
        
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(escena == 0)
            {
                cambioEscena(1);
            }
            if (escena == 1)
            {
                cambioEscena(2);
            }
        }
        else if(escena == 3)
        {
            txtResultado.text = PlayerPrefs.GetString("Resultado", "");
        }
        */
    }

    private void cambioEscena(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void cambioEscena(string resultado)
    {
        PlayerPrefs.SetString("Resultado", resultado);
        cambioEscena(3);
    }
}
