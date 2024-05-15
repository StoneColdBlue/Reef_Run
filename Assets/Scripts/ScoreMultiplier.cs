using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    public float duration = 10f;

    private bool isActivated = false;
    private PointsManager pointsManger;

    private void Start()
    {
        pointsManger = FindObjectOfType<PointsManager>();

        if (pointsManger == null)
        {
            Debug.Log("PointsManger not found in the scene!");
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && !isActivated)
        {
            ActivatePowerUp();
        }
    }

    private void ActivatePowerUp()
    {
        isActivated = true;
        pointsManger.SetDoubleScore(true);

        Invoke("DeactivatePowerUp", duration);

        Destroy(gameObject);
    }

    private void OnDestroy()
    {
        isActivated = false;
        pointsManger.SetDoubleScore(false);
    }
}
