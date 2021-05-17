using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatformScript : MonoBehaviour
{

    public float speed = 3.5f; 

    void Update()
    {
        //from 0,0,0 => 4,0,0 => 0,0,0
        //moves platform only x-axis
        transform.position = new Vector3 (Mathf.PingPong(Time.time*speed, 4), transform.position.y, transform.position.z);    
    }
}