using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SeeIfWinning : MonoBehaviour
{ 
    bool endGame = false;

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "winner")
        {
            Debug.Log("You win");
        }
        else if (gameObject.tag == "looser")
        {
            Debug.Log("You loose");
        }

        gameObject.GetComponent<AudioSource>().Play();

        endGame = true;
    }

    private void Update()
    {
        if (endGame)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }
}
