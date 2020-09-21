using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseButtons : MonoBehaviour
{
    public void BackToGame()
    {
        Manager.instance.UnPauseGame();
    }

    public void RestartGame()
    {
        Manager.instance.RestartGame();
    }
}
