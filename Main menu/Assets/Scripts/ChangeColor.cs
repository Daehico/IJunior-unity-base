using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] private Color color;

    public void ColorChanger(GameObject curentButon)
    {
        curentButon.TryGetComponent<Image>(out Image collorButton);
        if(collorButton != null)
        {
            collorButton.color = color;
        }
    }
}
