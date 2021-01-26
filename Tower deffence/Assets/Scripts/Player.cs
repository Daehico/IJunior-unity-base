using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;

    private int _gold;

    public event UnityAction<int> GoldChanged;
    public event UnityAction<int> HealthChanged;

    public int Health => _health;
    public int Gold => _gold;

    private void Start()
    {
        _gold = 0;
        GoldChanged?.Invoke(_gold);
    }

    public void AddGold(int gold)
    {
        _gold += gold;
        GoldChanged?.Invoke(_gold);
        Debug.Log(_gold);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);
    }
}
