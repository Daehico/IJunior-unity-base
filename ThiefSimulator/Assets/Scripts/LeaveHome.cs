using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaveHome : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<ChangeVolume>(out ChangeVolume player))
        {
            player.StopAudio();
        }
    }
}
