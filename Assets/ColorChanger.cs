using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MixedReality.Toolkit.UX;

public class ColorChanger : MonoBehaviour
{
    // Start is called before the first frame update
    public Renderer ball;
    public Slider slider;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        ball.material.color = Color.HSVToRGB(slider.Value, 1, 1);
        Debug.Log(slider.Value);
    }
}
