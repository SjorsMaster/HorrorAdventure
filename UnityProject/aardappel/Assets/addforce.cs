using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addforce : MonoBehaviour
{

    public float thrust;
    public Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKey("w"))
            rb.AddForce(Vector3.forward);


        if (Input.GetKey("space"))
            rb.AddForce(Vector3.up * 10, ForceMode.Impulse);


        if (Input.GetKey("s"))
            rb.AddForce(Mathf.Sin(Time.deltaTime), Mathf.Sin(Time.deltaTime), Mathf.Sin(Time.deltaTime), ForceMode.Impulse);
    }
}
