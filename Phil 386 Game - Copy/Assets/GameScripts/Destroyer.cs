using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour
{
    public GameObject destroyed;
    public GameObject Player;
    public int money;
    public int rep;
    // Start is called before the first frame update
    public void Test(){
       var script = Player.GetComponent<PlayerStats>();
       
        script.Money += money;
        script.Reputation += rep;
        Destroy(destroyed);
    }
    void Start()
    {
        StartCoroutine(deleter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void delete(){
        Destroy(destroyed);

    }
    private IEnumerator deleter(){
            if (destroyed.name != "Option"){
        WaitForSeconds wait = new WaitForSeconds(Random.Range(10f,30f));
        while (true){
       
           
            yield return wait;
   
             delete();
        }
           
        }
    }
}
