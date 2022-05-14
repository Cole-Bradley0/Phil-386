using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateOption : MonoBehaviour
{
    public GameObject CloneObject;
    public GameObject CloneDestination;
    public int Rep;
    public int Money;
    public ShopScript shopScript;
    // Start is called before the first frame update
    void Start()
    {
        
        
            StartCoroutine(createObjects());
            
    }


    public void CreateUi(){
         string RepText;
        string MoneyText;
        
        string[] perfectActions = {"Make software better","Create a new feature"};
        string[] goodActions = {"Less aggressive business model","Make app less addictive","Make TOS easier to read"};
        string[] badActions = {"More aggressive business model","Make app more addictive","Make app harder to unsubscribe","Hack competitors"};
            
        GameObject clone = Instantiate(CloneObject);
             Rep = 0;
        Money = 0;

        if (Random.Range(0,4) == 0){
             clone.transform.GetChild(0).gameObject.GetComponent<Text>().text = perfectActions[Random.Range(0,perfectActions.Length)];
            Rep = Random.Range(1,10) + (int)shopScript.repAdd;
         Money = Random.Range(10,100) + (int)shopScript.moneyAdd;
          clone.GetComponent<Image>().color = new Color32(0,255,0,100);
        }
        else {
            
             clone.GetComponent<Image>().color = new Color32(255,255,0,100);
          
            if (Random.Range(0,2) == 0){
                clone.transform.GetChild(0).gameObject.GetComponent<Text>().text = badActions[Random.Range(0,badActions.Length)];
                Rep = Random.Range(-60,-10) + (int)shopScript.repAdd;
         Money = Random.Range(50,140) + (int)shopScript.moneyAdd;

            }
            else{
                clone.transform.GetChild(0).gameObject.GetComponent<Text>().text = goodActions[Random.Range(0,goodActions.Length)];
                Rep = Random.Range(1,10) + (int)shopScript.repAdd;
         Money = Random.Range(-100,-1) + (int)shopScript.moneyAdd;
        
            }
        }
         
        
            if (Rep < 0){
            RepText = "Reputation "+Rep;
        }
        else{
            RepText = "Reputation +"+Rep;
        }

        if (Money < 0){
            MoneyText = "Money "+Money;
        }
        else{
            MoneyText = "Money +"+Money;
        }
       
        
       
        if (Rep < 0){
            clone.transform.GetChild(1).gameObject.GetComponent<Text>().color = new Color32(255,0,0,255);
        }
        if (Money < 0){
            clone.transform.GetChild(2).gameObject.GetComponent<Text>().color = new Color32(255,0,0,255);
        }
        clone.transform.GetChild(1).gameObject.GetComponent<Text>().text = RepText;
        clone.transform.GetChild(2).gameObject.GetComponent<Text>().text = MoneyText;
       
        var script = clone.GetComponent<Destroyer>();
        script.money = Money;
        script.rep = Rep;
        
        clone.transform.parent = CloneDestination.transform;
        }
        
    

    
    // Update is called once per frame
    void Update()
    {
        
    }

    private IEnumerator createObjects(){

     
        while (true){
            //for (int i = 0; i < 3; i++) CreateUi();
           WaitForSeconds wait = new WaitForSeconds(Random.Range(5f,9f));
            
            yield return wait;
             CreateUi();
        }
    }


}
