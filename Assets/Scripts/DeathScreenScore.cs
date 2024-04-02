using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DeathScreenScore : MonoBehaviour
{
    
    public TextMeshProUGUI scoreText;
    public void IncrementScore()
    {
        scoreText.text = "Score: " + score;
    }
}
