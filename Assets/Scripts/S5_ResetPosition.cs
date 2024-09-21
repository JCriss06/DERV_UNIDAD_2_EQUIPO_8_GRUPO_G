using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class S5_RestPosition : MonoBehaviour
{
    [SerializeField] Transform origen;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            transform.position = origen.transform.position;
            transform.rotation = origen.transform.rotation;
        }   
    }
}
