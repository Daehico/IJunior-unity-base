using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealthPoint : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private bool _healOrDamage;
    private float _cooldown;
    private float _healthChanged = 10f;
    private float _healthChangedDelta = 0.1f;

    public void ChangeHP(bool heal)
    {
        _healOrDamage = heal;
        StartCoroutine(HPChangedCoroutine());
    }

    IEnumerator HPChangedCoroutine()
    {
        while (_cooldown < _healthChanged)
        {
           
            if (_healOrDamage == true)
            {
                slider.value += _healthChangedDelta;
            }
            else
            {
                slider.value -= _healthChangedDelta;
            }
            _cooldown += _healthChangedDelta;
            yield return null;
        }
        _cooldown = 0;
    }
}
