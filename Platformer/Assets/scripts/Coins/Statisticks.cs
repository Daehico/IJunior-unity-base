using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Statisticks 
{
    public static float Coins { get; private set; }

    public static void ChangeCoins(float coin)
    {
        Coins += coin;
    }
}
