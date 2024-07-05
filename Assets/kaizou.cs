using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaizou : MonoBehaviour
{
    public Rigidbody rb;
    public float pow = 20;
    new Vector3 force;
    // Start is called before the first frame update
    void Start()
    { 
        rb = GetComponent<Rigidbody>();
        force = new Vector3(pow, 0.0f,0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(force);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(-force);
        }
    }
}
