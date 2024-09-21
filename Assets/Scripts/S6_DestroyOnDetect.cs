using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class S6_DestroyOnDetect : MonoBehaviour
{
    Renderer rend;
    [SerializeField] TextMeshProUGUI text;
    int count;
    
    Color color;
    List<Color> colores = new List<Color>()
    {
        Color.green,
        Color.yellow,
        Color.magenta,
        Color.blue,
        Color.red,
        Color.white
    };


    void Start()
    {
        count = 0;
        rend = GetComponent<Renderer>();
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        GameObject obj = other.gameObject;
        if (obj.CompareTag("enemy"))
        {
            Destroy(obj);
            count++;
            rend.material.color = colores[count % colores.Count];
            text.text = count.ToString();
        }
    }
}