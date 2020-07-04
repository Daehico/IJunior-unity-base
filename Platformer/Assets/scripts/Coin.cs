using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private int _coinCost;

    private int _curentCoins;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent<Movement>(out Movement player))
        {  
            _curentCoins += _coinCost;
            Debug.Log($"Монетки {_curentCoins}");
            Destroy(gameObject);
        }
    }
}
