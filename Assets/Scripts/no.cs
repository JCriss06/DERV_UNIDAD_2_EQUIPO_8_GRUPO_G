using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class no : MonoBehaviour
{
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.right * -1 * 40, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
    }
    void FixedUpdate()
    {
        

    }
}
