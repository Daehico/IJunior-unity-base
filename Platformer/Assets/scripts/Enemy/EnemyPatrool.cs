using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrool : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private GameObject _aPoint;
    [SerializeField] private GameObject _bPoint;

    private bool _moveRight;

    private void Start()
    {
        _moveRight = true;
    }

    private void Update()
    {
        if (_moveRight == true)
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

        if(transform.position.normalized.x < _aPoint.transform.position.normalized.x)
        {
            _moveRight = true;
        }

        if(transform.position.normalized.x > _bPoint.transform.position.normalized.x)
        {
            _moveRight = false;
        }      
    }  
}
