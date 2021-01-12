using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectable : MonoBehaviour
{
    public static int collectableQuantity = 0;
    public Text collectableText;
    ParticleSystem collectablePart;


    // Start is called before the first frame update
    void Start()
    {
        collectablePart = GameObject.Find("CollectableParticle").GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collectablePart.transform.position = transform.position;
            collectablePart.Play();

            gameObject.SetActive(false);

            collectableQuantity++;
            collectableText.text = collectableQuantity.ToString();


        }
    }

}
