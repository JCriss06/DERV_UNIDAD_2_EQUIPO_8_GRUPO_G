using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S4_Movimiento : MonoBehaviour
{
    [SerializeField] float velocidad_rota = 10f;
    [SerializeField] float velocidad_move = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angulo = 5f * velocidad_rota * Time.deltaTime;
        //// xyz
        if (Input.GetKey(KeyCode.Q))
        {
        transform.Rotate(0, angulo * -1, 0);    
        }
        else if(Input.GetKey(KeyCode.E))
        {
        transform.Rotate(0,angulo,0);            
        }

        if (Input.GetKey(KeyCode.W))
        {
            transform.position += transform.forward * velocidad_move * Time.deltaTime;
;        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position += transform.forward * -1 * velocidad_move * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -1* velocidad_move * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * velocidad_move * Time.deltaTime;
        }
    }
}
