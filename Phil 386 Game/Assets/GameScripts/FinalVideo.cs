using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class FinalVideo : MonoBehaviour
{
    public VideoPlayer player;
    bool dont = true;

    IEnumerator Start()
    {
        yield return new WaitForSeconds(10f);
        dont = false;
    }

    void Update()
    {
        if(!dont && !player.isPlaying)
        {
            StartCoroutine(timer());
            dont = true;
        }
    }

    IEnumerator timer()

    {
        yield return new WaitForSeconds(3f);
        Application.Quit();
    }
}
