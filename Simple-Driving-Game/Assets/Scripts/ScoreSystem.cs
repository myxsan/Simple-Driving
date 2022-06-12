using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSystem : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    [SerializeField] private float scoreMultiplier;
    
    public const string HighestScoreKey = "HighestScore";
    
    private float score;
    void Start()
    {
        
    }

    void Update()
    {
        score += Time.deltaTime * scoreMultiplier;

        scoreText.text = Mathf.FloorToInt(score).ToString("00");
    }
    private void OnDestroy() {
        int currentHighScore = PlayerPrefs.GetInt(HighestScoreKey, 0);

        if(score > currentHighScore)
        {
            PlayerPrefs.SetInt(HighestScoreKey,Mathf.FloorToInt(score));
        }
    }
}
