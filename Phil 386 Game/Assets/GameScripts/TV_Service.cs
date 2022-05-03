using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class TV_Service : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public VideoClip[] videoClips;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [ContextMenu("asdf")]
    public void ChooseRandomClip()
    {
        videoPlayer.clip = videoClips[Random.Range(0, videoClips.Length)];
    }

}
