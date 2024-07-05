using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeTextScript : MonoBehaviour
{
    text text;
    
    public float T;
    public int M;
    
    // Start is called before the first frame update
    void Start()
    {
        M = 30;
        T = M;

    }

    // Update is called once per frame
    void Update()
    {
        

        T = M - Time.time;
        this.GetComponent<Text>().text = string.Format("{0:000}", T);

        if (T <= 0)
        {
            this.GetComponent<Text>().text ="000";
            GameObject obe = GameObject.Find("Text");
            text = obe.GetComponent<text>();
            text.M = 2;

            
        }
    }
   
}
