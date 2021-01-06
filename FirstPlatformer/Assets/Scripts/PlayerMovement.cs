using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D rbPlayer;
    public float speed = .5f;
    public float jumpSpeed = 300f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rbPlayer.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rbPlayer.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rbPlayer.AddForce(Vector2.up * jumpSpeed);
        }


    }
}
