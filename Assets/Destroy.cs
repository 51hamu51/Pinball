using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Destroy : MonoBehaviour
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
        
            // è’ìÀÇµÇΩëäéËÇ…PlayerÉ^ÉOÇ™ïtÇ¢ÇƒÇ¢ÇÈÇ∆Ç´
            if (collision.gameObject.tag == "UnderWall" && TimeTextScript.T > 0)
            {

                // 0.2ïbå„Ç…è¡Ç¶ÇÈ
                Destroy(gameObject, 0.2f);
                text text;
                GameObject obj = GameObject.Find("Text");
                text = obj.GetComponent<text>();
                text.M = 0;



                PointTextScript PointTextScript;
                GameObject obe = GameObject.Find("PointText");
                PointTextScript = obe.GetComponent<PointTextScript>();
                PointTextScript.P -= 1000;

            MissSoundScript MissSoundScript;
            GameObject oba = GameObject.Find("Base");
            MissSoundScript = oba.GetComponent<MissSoundScript>();
            MissSoundScript.B = 0;

        }

        
    }
   


}
