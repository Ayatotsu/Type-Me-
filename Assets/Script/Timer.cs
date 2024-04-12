using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;
public class Timer : MonoBehaviour
{
    public GameManager gameManager;

    [Header("In-game")]
    public TextMeshProUGUI txtScore;

    [Header("Game Over")]

    public TextMeshProUGUI txtLastScore;
    public TextMeshProUGUI txtHighScore;

    [Header("Initial Values")]
    public int totalScore;
    public int lastScore;
    public int highScore;

    public float timeRemaining = 122;
    public bool timeIsRunning = true;

    [Header("References")]
    public TextMeshProUGUI timeText;
    public GameObject gameOverPanel;
    public GameObject inGamePanel;
    
    
    // Start is called before the first frame update
    void Start()
    {
        timeIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (timeRemaining <= 1.2f)
        {
            GameOver();
            timeIsRunning = false;
            Time.timeScale = 0f;
            
        }

        if (timeIsRunning) 
        {
            
            if (timeRemaining <= 122) 
            {
                timeRemaining -= Time.deltaTime;
                TimeDisplay(timeRemaining);

                //saving score preferences
                if (totalScore <= highScore)
                {
                    PlayerPrefs.SetInt("p_lastScore", totalScore);
                    PlayerPrefs.Save();
                }
                if (totalScore > highScore)
                {
                    PlayerPrefs.SetInt("p_highScore", totalScore);
                    PlayerPrefs.Save();
                }

                //getting saved preferences and convert to string outputs
                highScore = PlayerPrefs.GetInt("p_highScore");
                txtScore.text = totalScore.ToString(); //ingame conversion
                txtHighScore.text = highScore.ToString();
                lastScore = PlayerPrefs.GetInt("p_lastScore");
                txtLastScore.text = lastScore.ToString();
            }
            
        }
    }


    void TimeDisplay(float timeToDisplay) 
    {
        timeToDisplay -= 1;
        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
        timeText.text = string.Format("{0:00} : {1:00}", minutes, seconds);
    }

    public void GameOver() 
    {
        if (!timeIsRunning)
        {
            inGamePanel.gameObject.SetActive(false);
            gameOverPanel.gameObject.SetActive(true);
        }
    }
}
