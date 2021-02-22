using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    [SerializeField] private GameObject _menuPanel;

    public void MenuPanelOpen()
    {
        Time.timeScale = 0f;
        _menuPanel.SetActive(true);
    }

    public void MenuPanelClose()
    {
        Time.timeScale = 1f;
        _menuPanel.SetActive(false);
    }
}
