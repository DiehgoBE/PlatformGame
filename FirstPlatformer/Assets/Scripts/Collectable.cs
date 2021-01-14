using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectable : MonoBehaviour
{
    public static int collectableQuantity = 0;
    Text collectableText;
    ParticleSystem collectablePart;
    AudioSource collectableAudio;


    // Start is called before the first frame update
    void Start()
    {
        collectableQuantity = 0;
        collectablePart = GameObject.Find("CollectableParticle").GetComponent<ParticleSystem>();
        collectableText = GameObject.Find("CollectableQuantityText").GetComponent<Text>();
        collectableAudio = GetComponentInParent<AudioSource>();
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
            collectableAudio.Play();

            gameObject.SetActive(false);

            collectableQuantity++;
            collectableText.text = collectableQuantity.ToString();


        }
    }

}
