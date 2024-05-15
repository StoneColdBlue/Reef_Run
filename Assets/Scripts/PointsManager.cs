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

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        instan = this;
    }
    void triggBoss()
    {
        if (score == 50)
        {
            SceneManager.LoadScene(2);
        }
        else if (score == 100)
        {
            SceneManager.LoadScene(0);
        }
        else if (score == 150)
        {
            SceneManager.LoadScene(2);
        }
        else if(score == 200)
        {
            SceneManager.LoadScene(0);
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
