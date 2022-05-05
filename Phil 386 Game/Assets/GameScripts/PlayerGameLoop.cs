using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerGameLoop : MonoBehaviour
{
    public Canvas GameCanvas;
    private bool showInventory;
    public Canvas ECanvas;
    public PlayerRaycast raycastScript;
    public int actions;
    public int day;
    public Text Day;
    // Start is called before the first frame update
    void Start()
    {
        day = 0;
        actions = 5;
        showInventory = false;
    }

    // Update is called once per frame
    void Update()
    {
        Day.text = "Day: " + day;
        if (actions <= 0)
        {
            day++;
            actions = 5;
        }
        
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
