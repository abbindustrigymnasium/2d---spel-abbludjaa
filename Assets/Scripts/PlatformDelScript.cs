using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDelScript : MonoBehaviour
{
    public float playerY = 1;
    public float platformY = 1;
    // Start is called before the first frame update
    void Start()
    {
          
    }

    // Update is called once per frame
    void Update()
    {
        playerY = GameObject.Find("Player").GetComponent<DeathScript>().CurrentY;

         platformY = GetComponent<Rigidbody2D>().position.y;

         if (platformY+5 <= playerY)
        {
            Destroy(gameObject);
        }
    }
}
