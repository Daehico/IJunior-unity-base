using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameObject _deathPanel;
    [SerializeField] private GoldChanger _goldChange;

    public event UnityAction<int> GoldChanged;
    public event UnityAction<int> HealthChanged;

    public int Health => _health;
    public int Gold { get; private set;}

    private void Start()
    {
        Gold = 100;
    }

    private void Update()
    {
        if (_health <= 0)
            PlyerDie();
    }

    public void AddGold(int gold)
    {
        Gold += gold;
        GoldChanged?.Invoke(Gold); 
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);
    }

    private void PlyerDie()
    {
        Time.timeScale = 0;
        _deathPanel.SetActive(true);
    }
}
