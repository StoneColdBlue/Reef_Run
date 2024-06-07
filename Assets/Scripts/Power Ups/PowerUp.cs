 using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public float trunSpeed = 90f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<EndlessSpwan>() != null)
        {
            Destroy(other.gameObject);
            return;
        }

        if (other.CompareTag("Player"))
        {
            PowerUpEvents.OnPowerUpCollected.Invoke();
            GetComponent<Collider>().enabled = false;
            GetComponent<Renderer>().enabled = false;
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, trunSpeed * Time.deltaTime);
    }
}
