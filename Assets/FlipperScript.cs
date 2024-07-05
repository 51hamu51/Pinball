using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperScript : MonoBehaviour
{
    private GameObject FlipperR;
    private GameObject FlipperL;
    private Rigidbody rigidbodyR;
    private Rigidbody rigidbodyL;
    // Start is called before the first frame update
    float stFlipperLRotationY = -20;
    float stFlipperRRotationY = 20;
    float tmpFlipperLRotate = 0;
    float tmpFlipperRRotate = 0;
    public float rotateSpeed = 500;
   

    void Start()
    {
        FlipperR = GameObject.Find("FlipperRPivot");
        FlipperL = GameObject.Find("FlipperLPivot");
        rigidbodyR = FlipperR.GetComponentInChildren<Rigidbody>();
        rigidbodyR.centerOfMass = new Vector3(0.7f, 0, 0);
        rigidbodyL = FlipperL.GetComponentInChildren<Rigidbody>();
        rigidbodyL.centerOfMass = new Vector3(-0.7f, 0, 0);

    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKey(KeyCode.RightArrow))
        {
            if (tmpFlipperLRotate < 30)
            {
                tmpFlipperLRotate += rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperLRotate = 30;
            }
        }
        else
        {
            if (tmpFlipperLRotate > -30)
            {
                tmpFlipperLRotate -= rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperLRotate = -30;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (tmpFlipperRRotate < 30)
            {
                tmpFlipperRRotate += rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperRRotate = 30;
            }
        }
        else
        {
            if (tmpFlipperRRotate > -30)
            {
                tmpFlipperRRotate -= rotateSpeed * Time.deltaTime;
            }
            else
            {
                tmpFlipperRRotate = -30;
            }
        }

        rigidbodyL.MoveRotation(FlipperL.transform.rotation * Quaternion.Euler(0, -tmpFlipperLRotate, 0));
        rigidbodyR.MoveRotation(FlipperR.transform.rotation * Quaternion.Euler(0, tmpFlipperRRotate, 0));
    }
}
