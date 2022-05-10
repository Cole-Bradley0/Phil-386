using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVScript : MonoBehaviour
{
     public VideoPlayer player;
    public VideoClip[] clips;

    public bool cooldown = false;

    void Start()
    {

    }

    void Update()
    {
        if (!player.isPlaying && !cooldown)
        {
            PlayRandomClip();
        }
    }



    [ContextMenu("play")]
    void PlayRandomClip()
    {
        cooldown = true;
        player.clip = clips[Random.Range(0, clips.Length)];
        player.Play();
        StartCoroutine(CooldownTimer());
    }

    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(5f);
        cooldown = false;
    }
}
