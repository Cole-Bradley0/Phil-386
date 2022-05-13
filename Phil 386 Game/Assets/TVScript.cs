using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TVScript : MonoBehaviour
{
    public VideoPlayer player;
    public List<VideoClip> clips;

    public VideoClip badPressClip;

    public bool cooldown = false;

    int justPlayed = 0;

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

    //When you run this, the bad press clip gets added to
    // the list and can then randomly show up.
    [ContextMenu("Introduce Bad Press Clip")]
    public void IntroduceBadPressClip()
    {
        clips.Add(badPressClip);
    }


    [ContextMenu("play")]
    void PlayRandomClip()
    {
        cooldown = true;
        int random = justPlayed;
        while(random == justPlayed)
        {
            random = Random.Range(0, clips.Count);
        }
        player.clip = clips[random];
        justPlayed = random;
        player.Play();
        StartCoroutine(CooldownTimer());
    }

    IEnumerator CooldownTimer()
    {
        yield return new WaitForSeconds(5f);
        cooldown = false;
    }
}
