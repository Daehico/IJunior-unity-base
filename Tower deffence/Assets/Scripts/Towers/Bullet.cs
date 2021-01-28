﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private Enemy _enemy;

    private Vector3 _target;
    private Enemy _enemyTarget;

    private void Start()
    {
        ChangeTarget();
    }

    private void Update()
    {
        if (_enemyTarget == null)
            Destroy(gameObject);
        else
        {
            _target = _enemyTarget.transform.position;
            transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
        }       
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            Destroy(gameObject);
            enemy.ApplyDamage(_damage);         
        }
    }

    private void ChangeTarget()
    {
        _enemyTarget = FindObjectOfType<Enemy>();        
    }
}
