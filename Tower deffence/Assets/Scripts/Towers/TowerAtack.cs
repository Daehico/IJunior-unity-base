using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerAtack : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _delay;

    private float _currentTime;
    private List<Bullet> _bullets = new List<Bullet>();

    private void Start()
    {  
        _currentTime = _delay;
    }

    private void Shoot()
    {
        var bullet = Instantiate(_bullet, transform.position, Quaternion.identity);
        bullet.SetTowerAtack(gameObject.GetComponent<TowerAtack>());
        _bullets.Add(bullet);
        _currentTime = 0;
    }

    public void DestroyAllBullets()
    {
        foreach(var bullet in _bullets)
        {
            Destroy(bullet);
        }
        _bullets.Clear();
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out Enemy enemy))
        {
            _currentTime += Time.deltaTime;
            if (_currentTime >= _delay)
            {
                Shoot();
            }
        }      
    }
}
