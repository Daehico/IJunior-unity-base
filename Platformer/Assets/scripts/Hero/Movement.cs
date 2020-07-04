using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Vector2 _forceJump;

    private Rigidbody2D _rigidbody2D;
    private Animator _animator;

    public bool CanMove { get; private set; }

    void Start()
    {
        CanMove = true;
        _rigidbody2D = GetComponent<Rigidbody2D>();
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(CanMove == true) { 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * _speed * Time.deltaTime);
                _animator.SetTrigger("Move");

        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
                _animator.SetTrigger("Move");
            }
        if (Input.GetKey(KeyCode.Space))
        {
            _rigidbody2D.AddForce(_forceJump);
        }
        }
        _animator.SetTrigger("Don't move");
    }


    public void ChangeCanMove(bool change)
    {
        CanMove = change;
    }
}
