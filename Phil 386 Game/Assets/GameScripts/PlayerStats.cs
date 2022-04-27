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
    public Text Comment;
    public string[] comments = {"Test"};

    void Start(){
            StartCoroutine(createObjects());
    }
    // Update is called once per frame
    void Update()
    {
        MoneyGui.text = "$"+Money.ToString();
        if (Reputation > 200){
            Reputation = 200;
        }
        if (Reputation < 0){
            Reputation = 0;
        }
      
    }
    void CreateComment(){
        
        Comment.text = comments[Random.Range(0,comments.Length-1)];
    }
    private IEnumerator createObjects(){

     
        while (true){
            //for (int i = 0; i < 3; i++) CreateUi();
           WaitForSeconds wait = new WaitForSeconds(Random.Range(7f,12f));
            
            yield return wait;
             CreateComment();
        }
    }
}
