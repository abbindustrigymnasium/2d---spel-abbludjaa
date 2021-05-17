using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMomementScript : MonoBehaviour
{
    public float MovementSpeed = 1;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
       var movement = Input.GetAxis("Horizontal");
       transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;
    }
}
