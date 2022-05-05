using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public LayerMask layers;
    public GameObject interactionText;
    public bool lookingAtComputer;
    public float raycastLength = 5f;
    public bool lookingAtShop;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength, layers))
        {
            if (hit.transform.tag == "Shop"){
                lookingAtShop = true;
            }
            else{
                lookingAtShop = false;
            }
            if(hit.transform.tag == "Computer")
            {
                lookingAtComputer = true;
                
            }
            else
            {
                lookingAtComputer = false;
                
            }
        }
        else
        {
            lookingAtShop = false;
            lookingAtComputer = false;
        }
    }
}
