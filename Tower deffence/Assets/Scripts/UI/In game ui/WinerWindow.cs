using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinerWindow : MonoBehaviour
{
    [SerializeField] private GameObject _winerWindow;
    [SerializeField] private EnemySpawner _enemySpawner;

    private void OnEnable()
    {
        _enemySpawner.Win += EnebaleWinWindow;
    }

    private void OnDisable()
    {
        _enemySpawner.Win -= EnebaleWinWindow;
    }

    private void EnebaleWinWindow()
    {
        _winerWindow.SetActive(true);
    }
}
