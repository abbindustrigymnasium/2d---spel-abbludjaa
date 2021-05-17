using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    bool isGrounded = false;
    public Transform GroundCheck1; // prefab som tittas
    public LayerMask groundLayer; // layer som ska checkas
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
         isGrounded = Physics2D.OverlapCircle(GroundCheck1.position, 0.15f, groundLayer); // checks if you are within 0.15 position in the Y of the ground
 
       if (isGrounded = true && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
       {
         _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);  
       }
    }
}