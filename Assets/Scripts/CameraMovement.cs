using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

public Transform target;
public Vector2 cameraOffset; 

void Start()
    {

    }

    void Update () {
        transform.position = new Vector3(transform.position.x + cameraOffset.x, target.position.y + cameraOffset.y, -10);

    }
}
