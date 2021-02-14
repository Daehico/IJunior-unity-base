using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Enemy))]
public class EnemyHealthBarChanger : MonoBehaviour
{
    [SerializeField] private GameObject _curentHealthBar;

    private Enemy _enemy;
    private int maxHealth;

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();
    }

    private void OnEnable()
    {
        _enemy.EnemyHealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _enemy.EnemyHealthChanged -= OnHealthChanged;
    }

    private void OnHealthChanged()
    {
        _curentHealthBar.transform.localScale = new Vector3(_curentHealthBar.transform.localScale.x - 10, _curentHealthBar.transform.localScale.y);
        _curentHealthBar.transform.position = new Vector3(_curentHealthBar.transform.position.x - 0.25f, _curentHealthBar.transform.position.y);
    }
}
