﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHealthPoint : MonoBehaviour
{
    [SerializeField] private Slider slider;
    
    public void ChangeHP(float health)
    {
        slider.value += health;
    }
}
