using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PointsManager : MonoBehaviour
{

    public int score;
    public static PointsManager instan;

    public TextMeshProUGUI scoreText;

    public void IncrementScore()
    {
        score++;
        scoreText.text = "Score: " + score;
    }

    private void Awake()
    {
        instan = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
