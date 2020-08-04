using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float coins;

    public void AddCoins(float coin)
    {
        coins += coin;
        Debug.Log($"Монетки {coins}");
    }
}
