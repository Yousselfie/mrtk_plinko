using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserInputMoveBall : MonoBehaviour
{
    public float movingSpeed = 1;
    [SerializeField] Camera mainCam;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.position += new Vector3(-movingSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.position += new Vector3(movingSpeed * Time.deltaTime, 0, 0);
        }
        else if (Input.GetKey(KeyCode.Space))
        {
            this.AddGravityToBall();
            mainCam.transform.position = new Vector3(0, 10.3f, -7);
            mainCam.transform.eulerAngles = new Vector3(mainCam.transform.eulerAngles.x - 1.3f, mainCam.transform.eulerAngles.y, mainCam.transform.eulerAngles.z);
            this.enabled = false;
        }
    }

    private void AddGravityToBall()
    {
        gameObject.GetComponent<Rigidbody>().useGravity = true;
    }
}
