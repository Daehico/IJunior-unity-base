using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealthPoint : MonoBehaviour
{
    [SerializeField] private Slider slider;

    private bool hpChanged = false;
    private bool healOrDamage;
    private float cooldown;

    public void ChangeHP(bool heal)
    {
        hpChanged = true;
        healOrDamage = heal;
          
    }

    private void Update()
    {
        if(hpChanged == true)
        {
            if(healOrDamage == true)
            {
                slider.value += 0.1f;
            }
            else
            {
                slider.value -= 0.1f;
            }
            cooldown += 0.1f;
            if(cooldown >= 10)
            {
                hpChanged = false;
                cooldown = 0;
            }
        }
    }
}
