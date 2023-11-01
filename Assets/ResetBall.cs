using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetBall : MonoBehaviour
{
        public Vector3 originalPos;

        private void Start()
        {
            originalPos = transform.position;
        }

        public void ResetPos ()
    {
        gameObject.transform.position = originalPos;
    }
    }
