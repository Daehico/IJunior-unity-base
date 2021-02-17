using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Enemy))]
public class EnemyHealthBarChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private Enemy _enemy;

    private void OnEnable()
    {
        _enemy.EnemyHealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _enemy.EnemyHealthChanged -= OnHealthChanged;
    }

    private void Awake()
    {
        _enemy = GetComponent<Enemy>();
        _slider.maxValue = _enemy.Health;
        _slider.value = _enemy.Health;
    }

    private void OnHealthChanged()
    {
        _slider.value = _enemy.Health;
    }
}
