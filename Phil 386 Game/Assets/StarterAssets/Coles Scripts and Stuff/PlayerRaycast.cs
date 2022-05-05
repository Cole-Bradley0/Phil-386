using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRaycast : MonoBehaviour
{
    public LayerMask layers;
    public GameObject interactionText;
 
    public float raycastLength = 5f;
  
    public bool lookingAtSomething;
    public string tag;
    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, raycastLength, layers))
        {
                tag = hit.transform.tag;
                lookingAtSomething = true;
            
   

        }
        else{
            lookingAtSomething = false;
        }
    }
}
