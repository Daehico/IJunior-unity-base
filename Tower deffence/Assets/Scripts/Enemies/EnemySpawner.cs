using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;
    [SerializeField] private float _delay;
    [SerializeField] private int _countOfEnemies;

    private int _curentSpawnedEnemies;
    private float _curentTime;

    public event UnityAction<int, int> CountOfMobChanged;

    private void Start()
    {
        Spawn();
    }

    private void Update()
    {
        _curentTime += Time.deltaTime;
        if (_curentTime >= _delay && _curentSpawnedEnemies <= _countOfEnemies)
            Spawn();
    }

    private void Spawn()
    {
        Instantiate(_enemy, transform.position, Quaternion.identity);
        _curentSpawnedEnemies++;
        _curentTime = 0f;
        CountOfMobChanged?.Invoke(_curentSpawnedEnemies, _countOfEnemies);
    }
}
