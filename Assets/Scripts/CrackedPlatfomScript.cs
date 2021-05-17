using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrackedPlatfomScript : MonoBehaviour
{
    public float playerHighY = 1;
    public float crackedplatformY = 1;

    void Update()
    {
        playerHighY = GameObject.Find("Player").GetComponent<DeathScript>().CurrentY;

        crackedplatformY = GetComponent<Rigidbody2D>().position.y;        
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player" && playerHighY > crackedplatformY)
        {
            Destroy(gameObject);
        }
    }
}