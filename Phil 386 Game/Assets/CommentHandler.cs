using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CommentHandler : MonoBehaviour
{
    public Text comment;
    public PlayerStats playerStats;
    public TVScript tv;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(startComments());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreateComment(){
        string[] goodComments = {"5 out of 5 would buy again","This changed my life and I feel like I can go on again","I would recommend this to all my friends","This is the program that would save society from the edge of collapse","This is a useful program that I'll use everyday","Best thing since sliced bread","Use it all the time","Please and impressed with out it works","The program to get things done","11/10 this slaps"};
        string[] neutralComments = {"Well this works... or at least well enough","Needs more orange","I've used better but I've seen worse","Wait this isn't a review for ice cream","Somebody once told me the world was going to roll me...","This isn't an ice cream shop","There is a a lost dog I found looking for it's owner","What is up with the weather lately"};

        string[] badComments = {"0 out of 5 this software sucks","I'd have rather stub my toe than buy this again","Was this created over the course of a night","My children could make a better app","About as useful as a square wheel","It crashes more than it runs","Don't tell me this is the best thing program can do","Passing kidney stones is less painful","What was this program supposed to do cause this isn't it","Please take this down, it would do us all a favor"};
            if (playerStats.Reputation > 180){
                comment.text = goodComments[Random.Range(0,goodComments.Length-1)];
            }
            else if (playerStats.Reputation <= 180 && playerStats.Reputation > 160){
                comment.text = neutralComments[Random.Range(0,neutralComments.Length-1)];
            }
            else {
                comment.text = badComments[Random.Range(0,badComments.Length-1)];
                tv.IntroduceBadPressClip();
            }
            
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
