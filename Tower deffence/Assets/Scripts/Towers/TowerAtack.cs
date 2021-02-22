using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class TowerAtack : MonoBehaviour
{
    [SerializeField] private Bullet _bullet;
    [SerializeField] private float _delay;
    [SerializeField] private float _rotationSpeed;

    private float _currentTime;
    private AudioSource _audioSource;
    private Bullet _lastspawnedbullet;
    private Quaternion _LookRotation;
    private Vector3 _direction;
    private Enemy _enemy;


    private void Start()
    {
        _audioSource = GetComponent<AudioSource>();
        _currentTime = _delay;
    }

    private void Update()
    {
        if (_lastspawnedbullet != null)
        {
            _enemy = _lastspawnedbullet.SetEnemy();
            //transform.LookAt(_enemy.transform, new Vector3(0,0,-_enemy.transform.position.z));
            Vector3 direction = _enemy.transform.position - transform.position;
            Vector3 newDirection = new Vector3(0f, 0f, direction.z);
            Quaternion targetRotation = Quaternion.Euler(-newDirection);
            transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, _rotationSpeed * Time.deltaTime);
        }
    }

    private void Shoot()
    {
        _audioSource.Play();
        _lastspawnedbullet = Instantiate(_bullet, transform.position, Quaternion.identity);

        _currentTime = 0;
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out Enemy enemy))
        {
            _currentTime += Time.deltaTime;
            if (_currentTime >= _delay)
            {
                Shoot();
            }
        }
    }
}
