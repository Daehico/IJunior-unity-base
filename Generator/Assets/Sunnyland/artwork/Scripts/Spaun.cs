using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spaun : MonoBehaviour
{
    [SerializeField] private GameObject[] _spawnpoints;
    [SerializeField] private GameObject _enemyPrefab;

    private float _cooldown = 2f;
    private float _currentTime;
    private int _index = 0;

    private void Start()
    {
        Instantiate(_enemyPrefab, _spawnpoints[_index].transform.position, Quaternion.identity);
        _index++;
    }

    void Update()
    {
        _currentTime += Time.deltaTime;
        if(_currentTime >= _cooldown)
        {
            Instantiate(_enemyPrefab, _spawnpoints[_index].transform.position, Quaternion.identity);
            _index++;
            _currentTime = 0;
        }
        if(_index == _spawnpoints.Length)
        {
            _index = 0;
        }
    }
}
