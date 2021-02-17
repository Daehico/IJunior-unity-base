using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Reboot : MonoBehaviour
{
    public void RebootGame()
    {
        SceneManager.LoadScene(1);
    }
}
