using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowBall : MonoBehaviour
{
    [SerializeField] GameObject ball;
    bool followBall = false;

    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            followBall = true;
        }
        if (followBall)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, ball.transform.position.y + 1, gameObject.transform.position.z);
        }
    }
}
