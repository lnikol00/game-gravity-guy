using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelPanel;

    public void ReturnToMainMenu()
    {
        menuPanel.SetActive(true);
        levelPanel.SetActive(false);
    }

    public void OpenOnePlayer()
    {
        SceneManager.LoadScene(2);
    }

    public void OpenTwoPlayers()
    {
        SceneManager.LoadScene(3);
    }
}
