
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SeeIfWinning : MonoBehaviour
{
    public int score;


    private void OnTriggerEnter(Collider other) { 
    
        if  (GameObject.Find("scoreUI").GetComponent<TextMeshProUGUI>().text != score.ToString()) {
            score = 0;
        }

        if (gameObject.tag == "1000 points")
        {
            score += 1000;

            GameObject.Find("scoreUI").GetComponent<TextMeshProUGUI>().text = score.ToString();

        }
        else if (gameObject.tag == "500 points")
        {
            score += 500;
            GameObject.Find("scoreUI").GetComponent<TextMeshProUGUI>().text = score.ToString();

        }

        gameObject.GetComponent<AudioSource>().Play();
    }

        public void ResetScore()
    {
        GameObject.Find("scoreUI").GetComponent<TextMeshProUGUI>().text=score.ToString();

    }
}




