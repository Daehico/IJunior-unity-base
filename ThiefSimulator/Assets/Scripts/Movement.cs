using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private GameObject _endPoint;
    [SerializeField] private float speed;
    // Update is called once per frame
    private void Update()
    {
        transform.Translate(_endPoint.transform.position * speed * Time.deltaTime);
    }
}
