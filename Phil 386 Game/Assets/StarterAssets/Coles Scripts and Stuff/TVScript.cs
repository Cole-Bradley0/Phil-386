using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV_Service : MonoBehaviour
{
    public VideoPlayer player;
    public VideoClip badVid;
    public VideoClip[] clips;

    public PlayerStats stats;

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

    void playBadClip(){
        player.clip = badVid;
    }

    [ContextMenu("play")]
    void PlayRandomClip()
    {
        cooldown = true;
        
        player.clip = clips[Random.Range(0, 2)];
        player.Play();
        StartCoroutine(CooldownTimer());
    }

    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(5f);
        cooldown = false;
    }
}