using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;

public class PlayerGameLoop : MonoBehaviour
{
    public Canvas GameCanvas;
    private bool showInventory;
    public Canvas ECanvas;
    public PlayerRaycast raycastScript;
    public FirstPersonController movementScript;
    public Text Day;
    public int day;
    public int actions;

    // Start is called before the first frame update
    void Start()
    {
     
          actions = 5;
        day = 0;
        showInventory = false;
      
    }

    // Update is called once per frame
    void Update()
    {
        Day.text = "Day: "+day.ToString();
        if (actions <= 0)
        {
            day++;
            actions = 5;
        }
        if (raycastScript.lookingAtComputer){

                   ECanvas.enabled = true;
                  if (Input.GetKeyDown(KeyCode.E))
        {
            movementScript.enabled = false;
            showInventory = !showInventory;
            if (showInventory)
            {
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                GameCanvas.enabled = true;
            } else
            {
                movementScript.enabled = true;
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
