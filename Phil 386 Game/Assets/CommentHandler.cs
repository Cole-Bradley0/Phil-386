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
        string[] comments = {"5 out 5 would buy again This changed my life and I feel like I can go on again", "I would recommend this to all my friends","This is the program that would save society from the edge of collapse","This is a useful program that I'll use everyday","Well this works... or at least well enough","Needs more orange","I've used better but I've seen worse","Wai this isn't a review for ice cream", "Somebody once told me the world was going to roll me...","0 out of 5 this osftware sucks","I'd have rather stub my toe than buy this again","Was this created over the course of a night","My children could make a better app About as useful as a square wheel"};
            
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
