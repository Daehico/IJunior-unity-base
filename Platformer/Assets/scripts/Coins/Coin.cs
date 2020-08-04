using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinCost;
    [SerializeField] private Player player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Movement>(out Movement player))
        {
            this.player.AddCoins(_coinCost);
            Destroy(gameObject);
        }
    }
}
