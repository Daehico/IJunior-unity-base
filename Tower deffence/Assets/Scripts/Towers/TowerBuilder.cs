using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerBuilder : MonoBehaviour
{
    [SerializeField] private Tower _tower;
    [SerializeField] private Player _player;
    [SerializeField] private int _price;

    public void BuildTower(GameObject towerBuilder)
    {
        var tower = Instantiate(_tower, towerBuilder.transform.position, Quaternion.identity);
        tower.transform.Rotate(new Vector3(0, 0, -180));
        towerBuilder.SetActive(false);
        _player.AddGold(-_price);
    }
}
