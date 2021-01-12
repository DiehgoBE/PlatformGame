using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    Rigidbody2D rbEnemy;
    float timeBeforeChange;
    public float delay = .5f;
    public float speed = .3f;
    SpriteRenderer spEnemy;
    Animator animEnemy;
    ParticleSystem enemyPart;



    // Start is called before the first frame update
    void Start()
    {
        rbEnemy = GetComponent<Rigidbody2D>();
        spEnemy = GetComponent<SpriteRenderer>();
        animEnemy = GetComponent<Animator>();
        enemyPart = GameObject.Find("EnemyParticle").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        rbEnemy.velocity = Vector2.right * speed;

        if (speed > 0)
            spEnemy.flipX = false;
        else if (speed < 0)
            spEnemy.flipX = true;


        if (timeBeforeChange < Time.time)
        {
            speed *= -1;
            timeBeforeChange = Time.time + delay;

        }



    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (transform.position.y + .03f < collision.transform.position.y)
            {
                enemyPart.transform.position = transform.position;
                enemyPart.Play();
                animEnemy.SetBool("isDead", true);
            }
        }
    }

    public void DisableEnemy()
    {
        gameObject.SetActive(false);
    }

}
