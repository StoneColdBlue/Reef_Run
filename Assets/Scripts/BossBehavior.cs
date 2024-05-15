using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class BossBehavior : MonoBehaviour
{
    public float pace = 15;
    public float trunSpeed = 1f;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * pace * Time.fixedDeltaTime; //this makes the boss move forward continuesly
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int direc = Random.Range(0, 1);
        if (direc == 0)
        {
            transform.Rotate(0, trunSpeed * Time.deltaTime, 0);
        }
        else
        {
            transform.Rotate(trunSpeed * Time.deltaTime, 0, 0);
        }
    }
}
