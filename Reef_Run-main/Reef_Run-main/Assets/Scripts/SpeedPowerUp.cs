using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPowerUp : MonoBehaviour
{
    public float speedAmount = 0.5f;

    public float duration = 5f; 

    private bool isSpeedBoostActive = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            StartCoroutine(SpeedBoostActive(other));
        }
    }

    IEnumerator SpeedBoostActive(Collider player)
    {
        isSpeedBoostActive=true;

        CharacterMovement pace =player.GetComponent<CharacterMovement>();
        float originalPace = pace.pace; 

        pace.pace += speedAmount;
        
        GetComponent<Collider>().enabled = false;

        yield return new WaitForSeconds(duration);

        pace.pace -= speedAmount;
        isSpeedBoostActive = false; 
        Destroy(gameObject); 
    }
}
