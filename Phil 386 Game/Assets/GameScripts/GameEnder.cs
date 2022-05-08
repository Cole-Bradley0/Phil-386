using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnder : MonoBehaviour
{
    public int lastScene = 2;
    public AudioSource music;

    bool lerp = false;

    [ContextMenu("Test")]
    public void EndGame() {
        StartCoroutine(MusicAndSceneChange());
    }

    IEnumerator MusicAndSceneChange()
    {
        lerp = true;
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(lastScene);
    }

    private void Update()
    {
        if (lerp)
        {
            music.volume = Mathf.Lerp(music.volume, 0f, Time.deltaTime * 1.3f);
        }
    }
}
