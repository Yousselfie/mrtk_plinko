using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class change_color : MonoBehaviour
{
    public Renderer ballRenderer;
    [SerializeField] private Color newColor;
    [SerializeField] private Color[] colors;
    private int colorValue;
    // Start is called before the first frame update
    void Start()
    {
        ballRenderer = GameObject.Find("Ball").GetComponent<Renderer>();
    }

    public void ChangeColor()
    {
        colorValue++;
        if (colorValue > 2)
        {
            colorValue = 0;
        }
        ballRenderer.material.color = colors[colorValue];

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
