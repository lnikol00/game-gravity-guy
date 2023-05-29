using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class TwoPlayerGameController : MonoBehaviour
{
    public static bool IsGameOver;
    public static bool IsGamePaused;

    public GameObject PlayingUI;
    public GameObject PauseMenuUI;
    public GameObject GameOverUI;
    public Text GameOverScoreText;

    private static float playingBackgroungMusicTime;
    private AudioSource playingBackgroungMusic;

    void Awake()
    {
        IsGameOver = false;
        IsGamePaused = false;
        playingBackgroungMusic = GetComponent<AudioSource>();
        playingBackgroungMusic.time = playingBackgroungMusicTime;
        PlayingUI.SetActive(true);
        GameOverUI.SetActive(false);
        PauseMenuUI.SetActive(false);
    }

    void Start()
    {
        Time.timeScale = 1;
        TapsellStandardBanner.Hide();
        InvokeRepeating("addScore", 1f, 1f);
    }

    void Update()
    {
        if (!IsGameOver && Input.GetKeyDown(KeyCode.Escape))
        {
            PauseMenuToggle();
        }
    }

    private void addScore()
    {
        
    }

    public void GameOver()
    {
        IsGameOver = true;
        Time.timeScale = 0;
        TapsellStandardBanner.Show();
        CancelInvoke("AddScore");
        ColorEffect.ColorIndex++;
        PlayerPrefs.SetInt(MainController.Prefs_ColorIndex_Key, ColorEffect.ColorIndex);
        ColorEffect.ColorIndex--;
        PlayingUI.SetActive(false);
        GameOverScoreText.text = "Better Player Won!";
        GameOverUI.SetActive(true);
        playingBackgroungMusic.Pause();
        playingBackgroungMusicTime = playingBackgroungMusic.time;
        PlayerPrefs.Save();
    }


    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene(1);
        IsGameOver = false;
        IsGamePaused = false;
    }

    public void PauseMenuToggle()
    {
        if (!PauseMenuUI.activeSelf)
        {
            IsGamePaused = true;
            Time.timeScale = 0;
            playingBackgroungMusic.Pause();
            PauseMenuUI.SetActive(true);
        }
        else
        {
            IsGamePaused = false;
            PauseMenuUI.SetActive(false);
            if (PlayerPrefs.GetInt("sounds", 1) == 1)
            {
                playingBackgroungMusic.UnPause();
            }
            Time.timeScale = 1;
        }
    }
}
