using System.Collections;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using UnityEngine;



public class BallScript : MonoBehaviour
{
    TimeTextScript TimeTextScript;


    public GameObject BallPrefab;
    // Start is called before the first frame update
    public Transform ballTransform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obc = GameObject.Find("TimeText");
        TimeTextScript = obc.GetComponent<TimeTextScript>();

        if (TimeTextScript.T > 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (BallPrefab != null)
                {
                    GameObject ball = GameObject.Instantiate(BallPrefab);
                    ball.transform.position = ballTransform.position;

                    ball.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, -25);
                }
            }
        }
    }
}
