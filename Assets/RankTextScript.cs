using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankTextScript : MonoBehaviour
{
    TimeTextScript TimeTextScript;
    PointTextScript PointTextScript;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject obc = GameObject.Find("TimeText");
        TimeTextScript = obc.GetComponent<TimeTextScript>();
        GameObject obj = GameObject.Find("PointText");
        PointTextScript = obj.GetComponent<PointTextScript>();

        if (TimeTextScript.T < 0)
        {
            if(PointTextScript.P < 0)
            {
                this.GetComponent<Text>().text = "Dランク";
            }
            else if (PointTextScript.P < 1000)
            {
                this.GetComponent<Text>().text = "Cランク";
            }
            else if (PointTextScript.P < 5000)
            {
                this.GetComponent<Text>().text = "Bランク";
            }
            else if (PointTextScript.P < 10000)
            {
                this.GetComponent<Text>().text = "Aランク";
            }
            else 
            {
                this.GetComponent<Text>().text = "Sランク";
            }
        }
    }
}
