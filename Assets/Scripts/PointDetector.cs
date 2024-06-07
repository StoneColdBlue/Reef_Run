using UnityEngine;

public class PointDetector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Point"))
        {
            ScoreManager.IncreaseScore(1);
        }
    }
}

