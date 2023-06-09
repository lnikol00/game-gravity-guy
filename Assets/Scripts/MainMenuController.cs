﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuController : MonoBehaviour
{
    public GameObject QuitPopupUI;
    public GameObject InfoPanel;
    public Text BestScoreText;
    public GameObject menuPanel;
    public GameObject levelPanel;

    void Awake()
    {
        QuitPopupUI.SetActive(false);
        InfoPanel.SetActive(false);
        BestScoreText.text = "BEST SCORE\n" + PlayerPrefs.GetInt(MainController.Prefs_BestScore_Key, MainController.Prefs_BestScore_DefaultValue);
    }

    void Start()
    {
        TapsellStandardBanner.Hide();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitPopupToggle();
        }
    }

    public void Play()
    {
        menuPanel.SetActive(false);
        levelPanel.SetActive(true);
    }

    public void QuitPopupToggle()
    {
        if (!QuitPopupUI.activeSelf)
        {
            QuitPopupUI.SetActive(true);
        }
        else
        {
            QuitPopupUI.SetActive(false);
        }
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

    public void Quit()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #else

        #endif

        Application.Quit();
    }
}
