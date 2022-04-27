using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopScript : MonoBehaviour
{
    public Canvas GameCanvas;
   
    // Start is called before the first frame update
    void Start()
    { 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void openShop(){
        if (GameCanvas.enabled == false){
            GameCanvas.enabled = true;
        }
        else{
            GameCanvas.enabled = false;
        }
    }
}
