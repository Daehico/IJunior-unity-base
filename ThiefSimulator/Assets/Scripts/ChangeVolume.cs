using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeVolume : MonoBehaviour
{
    private AudioSource audio;
    private bool play;
    private float changeVoluneDelta = 0.1f;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    public void StopAudio()
    {
        StopCoroutine("StartVolume");
        audio.volume = 0;
        audio.Stop();
        play = false;
    }

    public void StartVolume()
    {
        play = true;
    }

    public IEnumerator AddVolume()
    {
        audio.volume += changeVoluneDelta;
        yield return null;
    }

    private void FixedUpdate()
    {
        if (play == true)
        {
            StartCoroutine(AddVolume());
        }
    }

}
