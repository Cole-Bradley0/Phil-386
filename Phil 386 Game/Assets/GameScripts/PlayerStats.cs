using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class PlayerStats : MonoBehaviour
{

    public Text MoneyGui;
    public Image ReputationGui;
    public int Money;
    public int Reputation;
    public Text finalR;
    public Text finalM;
    // Update is called once per frame
    void Update()
    {
        MoneyGui.text = "$"+Money.ToString();
          finalR.text = "Reputation: "+Reputation;
                    finalM.text = "Money: "+Money;
        if (Reputation > 200){
            Reputation = 200;
        }
        if (Reputation < 0){
            Reputation = 0;
        }
        ReputationGui.rectTransform.sizeDelta = new Vector2(Reputation,50);
    }
}
