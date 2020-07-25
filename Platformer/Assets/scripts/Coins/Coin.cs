using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinCost;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Movement>(out Movement player))
        {
            Statisticks.ChangeCoins(_coinCost);
            Debug.Log($"Монетки {Statisticks.Coins}");
            Destroy(gameObject);
        }
    }
}
