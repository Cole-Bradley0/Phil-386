using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerGameLoop : MonoBehaviour
{
    public Canvas GameCanvas;
    private bool showInventory;
    public Canvas ECanvas;
    public PlayerRaycast raycastScript;

    // Start is called before the first frame update
    void Start()
    {
        showInventory = false;
    }

    // Update is called once per frame
    void Update()
    {
    
        
        if (raycastScript.lookingAtComputer){
            
                   ECanvas.enabled = true;
                  if (Input.GetKeyDown(KeyCode.E))
        {
        
            showInventory = !showInventory;
            if (showInventory)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                GameCanvas.enabled = true;
            } else
            {
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                GameCanvas.enabled = false;
            }        

        }
        }else{
              ECanvas.enabled = false;
Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                GameCanvas.enabled = false;
        }
        
      
        
    }
}
