using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int _damage;
    [SerializeField] private float _speed;
    [SerializeField] private Enemy _enemy;

    private Vector3 _target;
    private Enemy _enemyTarget;
    private TowerAtack _towerAtack;

    private void OnEnable()
    {
        _enemy.EnemyDying += ChangeTarget;
    }

    private void OnDisable()
    {
        _enemy.EnemyDying -= ChangeTarget;
    }

    private void Start()
    {
        ChangeTarget();
    }

    private void Update()
    {
        _target = _enemyTarget.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _target, _speed * Time.deltaTime);
    }

    public void SetTowerAtack(TowerAtack towerAtack)
    {
        _towerAtack = towerAtack;
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
        _towerAtack.DestroyAllBullets();
    }
}
