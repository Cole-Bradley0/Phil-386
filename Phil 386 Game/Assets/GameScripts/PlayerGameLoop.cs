using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using StarterAssets;
using UnityEngine.SceneManagement;


public class PlayerGameLoop : MonoBehaviour
{
    public Canvas GameCanvas;
    public Canvas ending;
    public Canvas ending2;
    private bool showGUI;
    public TVScript tv;
    public Canvas ECanvas;
    public MouseLook mouseLookY;
    public MouseLook mouseLookX;
    public FirstPersonController movement;


    public Canvas ShopCanvas;

    public PlayerRaycast raycastScript;
    public int actions;
    public int day;
    public Text Day;


    // Start is called before the first frame update
    void Start()
    {
        day = 0;
        actions = 5;
        showGUI = false;
    }

    // Update is called once per frame
    void Update()
    {

       if (day < 5){
       
            ending.enabled = false;
        
       }
       else{
           ending.enabled = true;
       }
                if (Input.GetKeyDown(KeyCode.Space))
            {

                 if (day >= 5){
                   
                     ending2.enabled = true;
                     
                     StartCoroutine(timer());
                     
            day = 0;
            
                
            }
            
        }
       
        Day.text = "Day: " + day;
        if (actions <= 0)
        {
            day++;
            actions = 5;
        }
        
        if (raycastScript.lookingAtSomething){
            if (raycastScript.tag != "Untagged"){
                   ECanvas.enabled = true;
                  if (Input.GetKeyDown(KeyCode.E))
        {
        
            showGUI = !showGUI;
            if (showGUI)
            {
                mouseLookY.enabled = false;
                mouseLookX.enabled = false;
                movement.enabled = false;
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
                switch(raycastScript.tag){
                    case "Computer":
                        GameCanvas.enabled = true;
                        break;
                    case "Shop":
                        ShopCanvas.enabled = true;
                        
                        break;
                }
                
            } else
            {
                movement.enabled = true;
                mouseLookY.enabled = true;
                mouseLookX.enabled = true;
                Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                GameCanvas.enabled = false;
                ShopCanvas.enabled = false;
            }        

        }
        }else{
              ECanvas.enabled = false;
              movement.enabled = true;
                mouseLookY.enabled = true;
                mouseLookX.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;
                Cursor.visible = false;
                GameCanvas.enabled = false;
                ShopCanvas.enabled = false;
        }
        }



    }

    IEnumerator timer()

    {
        yield return new WaitForSeconds(7f);
        SceneManager.LoadScene(2);
       
        
    }
    
}
