using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Rigidbody2D rbEnemy;
    float timeBeforeChange;
    public float delay = .5f;
    public float speed = .3f;




    // Start is called before the first frame update
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rbEnemy.velocity = Vector2.right * speed;

        if (timeBeforeChange < Time.time)
        {
            speed *= -1;
            timeBeforeChange = Time.time + delay;

        }



    }
}
