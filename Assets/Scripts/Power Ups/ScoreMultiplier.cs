using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreMultiplier : MonoBehaviour
{
    public float duration = 10f; 
    public float turnSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PowerUpEvents.OnScoreMultiplier.Invoke(duration);
            GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
            Destroy(gameObject, duration);
        }
    }

    void Update()
    {
        transform.Rotate(0,0,turnSpeed * Time.deltaTime);
    }
}
