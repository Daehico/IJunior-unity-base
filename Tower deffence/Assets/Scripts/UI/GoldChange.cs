using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldChange : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private TMP_Text _text;

    private void OnEnable()
    {
        _player.GoldChanged += OnGoldChanged;

    }

    private void OnDisable()
    {
        _player.GoldChanged -= OnGoldChanged;
    }

    private void OnGoldChanged(int gold)
    {
        _text.text = _player.Gold.ToString();
        Debug.Log(gold);
    }
}
