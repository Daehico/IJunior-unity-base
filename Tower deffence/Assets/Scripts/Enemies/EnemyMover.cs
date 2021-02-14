using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private GameObject[] _wayPoints;
    [SerializeField] private float _speed;

    private Vector3 _curentWaypoint;
    private int _idOfwaypoint;

    private void Start()
    {
        _idOfwaypoint = 0;
        GetNewWaypoint();
    }

    private void Update()
    {
        if(transform.position == _curentWaypoint)
        {
            _idOfwaypoint++;
            GetNewWaypoint();
        }        
        transform.position = Vector3.MoveTowards(transform.position, _curentWaypoint, _speed * Time.deltaTime);
    }

    private void GetNewWaypoint()
    {
        _curentWaypoint = _wayPoints[_idOfwaypoint].transform.position;
        if (_idOfwaypoint > 0)
            transform.Rotate(new Vector3(0, 0, transform.rotation.z -90));
    }
}
