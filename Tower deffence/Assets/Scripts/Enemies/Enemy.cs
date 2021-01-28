using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private int _goldForKill;
    [SerializeField] private Player _player;
    [SerializeField] private int _damage;

    public int Damage => _damage;

    public event UnityAction EnemyHealthChanged;

    private void Update()
    {
        if(_health<= 0)
        {
            EnemyDie();
        }
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        EnemyHealthChanged?.Invoke();
    }

    private void EnemyDie()
    {
        _player.AddGold(_goldForKill);
        Destroy(gameObject);
    }
}
