using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    [SerializeField] private Slider _slider;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= OnHealthChanged;
    }

    private void Awake()
    {
        _slider.maxValue = _player.Health;
        _slider.value = _player.Health;
    }

    private void OnHealthChanged(int health)
    {
        _slider.value = health;
    }
}
