using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Signalization : MonoBehaviour
{
    private AudioSource audio;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Movement>(out Movement player))
        {
            audio = player.GetComponent<AudioSource>();
            audio.Play();
            var changeVolume = audio.gameObject.GetComponent<ChangeVolume>();
            changeVolume.StartVolume();
        }
    }
}
