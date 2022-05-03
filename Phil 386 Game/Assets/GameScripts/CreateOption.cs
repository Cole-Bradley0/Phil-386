using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CreateOption : MonoBehaviour
{
    public GameObject CloneObject;
    public GameObject CloneDestination;
    private int Rep;
    private int Money;

    // Start is called before the first frame update
    void Start()
    {

       
        StartCoroutine(createObjects());
            
    }

    
    public void CreateUi(){
         string RepText;
        string MoneyText;
        
        string[] Actions = {"Ejiofsea"};
            
        GameObject clone = Instantiate(CloneObject);
             Rep = 0;
        Money = 0;

        if (Random.Range(0,4) == 0){
            Rep = Random.Range(1,10);
         Money = Random.Range(10,100);
          clone.GetComponent<Image>().color = new Color32(0,255,0,100);
        }
        else {
             clone.GetComponent<Image>().color = new Color32(255,255,0,100);
          
            if (Random.Range(0,2) == 0){
                Rep = Random.Range(-10,-1);
         Money = Random.Range(10,100);

            }
            else{
                Rep = Random.Range(1,10);
         Money = Random.Range(-100,-1);
        
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
       
        
        clone.transform.GetChild(0).gameObject.GetComponent<Text>().text = "test";
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
           WaitForSeconds wait = new WaitForSeconds(Random.Range(7f,12f));
            
            yield return wait;
             CreateUi();
        }
    }


}
