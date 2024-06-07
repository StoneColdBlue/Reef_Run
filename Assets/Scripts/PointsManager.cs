using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System.Diagnostics;

public class PointsManager : MonoBehaviour
{

    public int score;
    public static PointsManager instan;

    public TextMeshProUGUI scoreText;

    public int value;

    public TextMeshProUGUI deathScore;

    public TextMeshProUGUI bossScore;

    private bool isDoubleScoreActivate = false;

    public static int points;


    public void IncrementScore()
    {
        int scoreIncrement = isDoubleScoreActivate ? 2 : 1;
        score += scoreIncrement;
        scoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        instan = this;
        points = PlayerPrefs.GetInt("Points", 0);
    }
    
    public void SetDoubleScore(bool doubleScore)
    {
        isDoubleScoreActivate = doubleScore;
    }
    void triggBoss()
    {
        if (score >= 50)
        {
            SceneManager.LoadScene(2);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        value = PlayerPrefs.GetInt("ScoreSave");
        deathScore.text = "Score: " + value;
        score = value;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("ScoreSave", score);
        triggBoss();
    }
}