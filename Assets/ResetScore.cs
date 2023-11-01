using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class ResetScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void resetScore()
    {
       GameObject.Find("scoreUI").GetComponent<TextMeshProUGUI>().SetText(500+"");
    }
}
