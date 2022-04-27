using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisionColl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            print(collision);
            Debug.DrawRay(contact.point, contact.normal, Color.white);
        }
       
    }
}
