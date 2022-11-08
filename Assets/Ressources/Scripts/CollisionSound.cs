using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class CollisionSound : MonoBehaviour
{

    AudioSource[] audioSrc;
    

    private void Awake()
    {
        audioSrc = gameObject.GetComponents<AudioSource>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.gameObject.name);

        //TODO - temporary solution
        if (collision.gameObject.name == "Cylinder")
        {
            audioSrc[0].Play();
        }
        else
        {
            audioSrc[1].Play();
        }
        //if(collision.gameObject.tag == ...)
    }
}
