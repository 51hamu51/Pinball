using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class text : MonoBehaviour
{
    TimeTextScript TimeTextScript;
    
    public int M, count;
    // Start is called before the first frame update
    void Start()
    {

        M = 1;
        count = 0;
        

    }

    // Update is called once per frame
    void Update()
    {
        GameObject obe = GameObject.Find("TimeText");
        TimeTextScript = obe.GetComponent<TimeTextScript>();
        if (TimeTextScript.T > 0)
        {
            if (M == 1)
            {
                this.GetComponent<Text>().text = "がんばって！！";
            }
            else if (M == 0)
            {
                this.GetComponent<Text>().text = "ざーこざーこwww";
                count++;
                if (count > 500)
                {
                    M = 1;
                    count = 0;
                }

            }
        }
                if(M == 2){
            this.GetComponent<Text>().text = "おつかれさま！！";
        }
       
    }


}
