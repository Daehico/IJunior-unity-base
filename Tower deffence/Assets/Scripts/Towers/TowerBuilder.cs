using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private Tower _tower;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D _raycastHit2D = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if(_raycastHit2D.collider.TryGetComponent(out TowerBuilder towerBuilder))
            {
                var tower =Instantiate(_tower, transform.position,Quaternion.identity);
                tower.transform.Rotate(new Vector3(0, 0, -180));
                gameObject.SetActive(false);
            }

        }
    }
}
