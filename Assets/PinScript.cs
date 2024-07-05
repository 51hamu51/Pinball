using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinScript : MonoBehaviour
    
{
    TimeTextScript TimeTextScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obc = GameObject.Find("TimeText");
        TimeTextScript = obc.GetComponent<TimeTextScript>();
    }

    void OnCollisionEnter(Collision collision)
    {

        // Õ“Ë‚µ‚½‘ŠŽè‚ÉPlayerƒ^ƒO‚ª•t‚¢‚Ä‚¢‚é‚Æ‚«
        if (collision.gameObject.tag == "Ball" && TimeTextScript.T > 0)
        {

            



            PointTextScript PointTextScript;
            GameObject obe = GameObject.Find("PointText");
            PointTextScript = obe.GetComponent<PointTextScript>();
            PointTextScript.P += 100;



        }
    }
}
