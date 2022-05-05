using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CommentHandler : MonoBehaviour
{
    public Text comment;
    public 
    // Start is called before the first frame update
    void Start()
    {
        startComments();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateComment(){
        string[] comments = {"Test","Lol","Pop"};
            
            comment.text = comments[Random.Range(0,comments.Length-1)];
    }



     private IEnumerator startComments(){

     
        while (true){
            //for (int i = 0; i < 3; i++) CreateUi();
           WaitForSeconds wait = new WaitForSeconds(Random.Range(7f,12f));
            
            yield return wait;
             CreateComment();
        }
    }
}
