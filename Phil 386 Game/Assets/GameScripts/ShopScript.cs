using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ShopScript : MonoBehaviour
{

    public double repAdd;
    public double moneyAdd;
    public double repAddCost;
    public double devHireCost;

    public CreateOption playerScript;
    public PlayerStats playerStats;
    public Text uxPR;
    public Text uxDevHire;
    // Start is called before the first frame update
    void Start()
    { 
  
    }

    // Update is called once per frame
    void Update()
    {
     uxPR.text = "PR Cost: $"+Mathf.Round((float)repAddCost);
     uxDevHire.text = "Dev Hire Cost: $"+Mathf.Round((float)devHireCost);   
    }
    public void buyPR(){
        if (playerStats.Money >= (int)repAddCost){
            playerStats.Money -= (int)repAddCost;
            playerScript.Money -= (int)repAddCost;
            repAddCost = repAddCost * 1.2;
            repAdd = repAdd * 1.2;
        }
    }
    public void buyDev(){
        if (playerStats.Money >= (int)devHireCost){
            playerStats.Money -= (int)devHireCost;
            playerScript.Money -= (int)devHireCost;
            devHireCost = devHireCost * 1.2;
            moneyAdd = moneyAdd * 1.2;
        }
    }
}
