using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class HealthPointsChanger : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    private bool _healOrDamage;
    private float _cooldown;
    private float _healthChanged = 10f;
    private float _healthChangedDelta = 0.1f;

    public void ChangeHP(bool heal)
    {
        _healOrDamage = heal;
        StartCoroutine(HPChanged());
    }

    IEnumerator HPChanged()
    {
        while (_cooldown < _healthChanged)
        {
           
            if (_healOrDamage == true)
            {
                _slider.value += _healthChangedDelta;
            }
            else
            {
                _slider.value -= _healthChangedDelta;
            }
            _cooldown += _healthChangedDelta;
            yield return null;
        }
        _cooldown = 0;
    }
}
