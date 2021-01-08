using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float speed = .5f;
    public float jumpSpeed = 300f;
    bool isGrounded = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rbPlayer.velocity.y);

        if (isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                rbPlayer.AddForce(Vector2.up * jumpSpeed);
                isGrounded = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }

}
