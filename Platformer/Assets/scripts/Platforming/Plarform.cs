using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plarform : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Movement>(out Movement player))
        {
            player.UnFreezMovement();
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.TryGetComponent<Movement>(out Movement player))
        {
            player.FreezMovement();
        }
    }  
}
