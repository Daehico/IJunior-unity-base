using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GoldChanger : MonoBehaviour
{
    [SerializeField] private TMP_Text _text;
    [SerializeField] private Player _player;

    private void OnEnable()
    {
        _player.GoldChanged += GoldChange;
        GoldChange(_player.Gold);
    }

    private void OnDisable()
    {
        _player.GoldChanged -= GoldChange;
    }

    public void GoldChange(int gold)
    {
        _text.text = gold.ToString();
    }
}
