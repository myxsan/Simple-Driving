using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MainMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text highestScoreText;

    private void Start() {
        SetHighestScore();
    }

    private void SetHighestScore()
    {
        int highestScore = PlayerPrefs.GetInt(ScoreSystem.HighestScoreKey, 0);
        highestScoreText.text = $"Highest Score: {highestScore}";
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }
}
