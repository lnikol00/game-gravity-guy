using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject levelPanel;
    public GameObject InfoPanel;

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

    public void InfoPopupToggle()
    {
        if(!InfoPanel.activeSelf)
        {
            InfoPanel.SetActive(true);
        }
        else
        {
            InfoPanel.SetActive(false);
        }
    }
}
