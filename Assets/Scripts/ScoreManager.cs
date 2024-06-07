using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static int score = 0;

    public static void IncreaseScore(int amount)
    {
        score += amount;
        if (score >= 50)
        {
            SceneManager.LoadScene(2);
        }
    }
}

