using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedAmount = 0.5f;
    public float duration = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PowerUpEvents.OnSpeedBoost.Invoke(speedAmount, duration);
            GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
            Destroy(gameObject,duration);
        }
    }
}
