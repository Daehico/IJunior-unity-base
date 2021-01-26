using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MobChange : MonoBehaviour
{
    [SerializeField] private EnemySpawner _enemySpawner;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _enemySpawner.CountOfMobChanged += OnCountMobChanger;
    }

    private void OnDisable()
    {
        _enemySpawner.CountOfMobChanged -= OnCountMobChanger;
    }

    private void OnCountMobChanger(int curentmobs, int allmobs)
    {
        _text.text = curentmobs.ToString() + "/" + allmobs.ToString();
    }
}
