using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(1);
    }

    public void OpenOnePlayer()
    {
        SceneManager.LoadScene(3);
    }

    public void OpenTwoPlayers()
    {
        SceneManager.LoadScene(4);
    }
}
