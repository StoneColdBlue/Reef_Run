using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterMovement : MonoBehaviour
{
    bool alive = true; // sets the charater to be alive by default 

    public float pace = 10; //the constant speed of the charater
    float subPace = 1;
    public Rigidbody rb; // tis is to link to the charater

    float horizontalInput; //this is a variable to store the horizontal in puts
    public float horizontalMulti = 2; // this increses the speed

    float verticalInput; // a variable to store the vertical input
    public float verticalMulti = 1;//this was a multiplyer but it couses the charater to jump to high

    private void FixedUpdate()
    {
        if (!alive) return;//checks if the charater is dead or alive
        Vector3 forwardMove = transform.forward * pace * Time.fixedDeltaTime ; //this makes the player move forward continuesly
        Vector3 verticalMove = transform.up * verticalInput * pace * Time.fixedDeltaTime * verticalMulti;//recives vertical inputs
        Vector3 horizontalMove = transform.right * horizontalInput * pace * Time.fixedDeltaTime * horizontalMulti;//recives horizontal inputs
        rb.MovePosition(rb.position + forwardMove + horizontalMove + verticalMove);//compiles all inputs to the charater
        for (int i = 0; i < 10; i++)
        {
            pace = (float)(pace + 0.0001);
        };
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");//gets the input from the player
        verticalInput = Input.GetAxis("Vertical");//gets the input from the player

        // kills the player if they fall of the map
        if (transform.position.y < -5)
        {
            Death();
        };
    }

    public void Death()
    {
        //kills the player
        alive = false;
        //restarts the game
        Invoke("DeathScreen", 2);
        DeathScreen();
    }

    void DeathScreen()//a function to restarts the game 
    {
        SceneManager.LoadScene(3);
    }

    private void OnEnable()
    {
        PowerUpEvents.OnSpeedBoost.AddListener(HandleSpeedBoost);    
    }

    private void OnDisable()
    {
        PowerUpEvents.OnSpeedBoost.RemoveListener(HandleSpeedBoost);
    }

    private void HandleSpeedBoost(float speedAmount, float duration)
    {
        StartCoroutine(SpeedBoostCoroutine(speedAmount, duration));
    }

    private IEnumerator SpeedBoostCoroutine(float speedAmount, float duration)
    {
        pace += speedAmount;
        yield return new WaitForSeconds(duration);
        pace -= speedAmount;
    }
}