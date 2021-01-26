using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    [SerializeField] private GameObject[] _wayPoints;
    [SerializeField] private float _speed;

    private Vector3 _curentWaypoint;
    private int id;

    private void Start()
    {
        id = 0;
        GetNewWaypoint();
    }

    private void Update()
    {
        if(transform.position == _curentWaypoint)
        {
            id++;
            GetNewWaypoint();
        }        
        transform.position = Vector3.MoveTowards(transform.position, _curentWaypoint, _speed * Time.deltaTime);
    }

    private void GetNewWaypoint()
    {
        _curentWaypoint = _wayPoints[id].transform.position;
        if (id > 0)
            transform.Rotate(new Vector3(0, 0, transform.rotation.z -90));
    }
}
