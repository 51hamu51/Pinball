using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class PointTextScript : MonoBehaviour
{
    public int P;
    
    // Start is called before the first frame update
    void Start()
    {
        P = 0;
        
    }

    // Update is called once per frame
    void Update()
    {
        

       
            this.GetComponent<Text>().text = string.Format("{0:0000000}", P);
        

        
       
    }
}
