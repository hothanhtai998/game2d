using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{


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
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Move up");
        }
        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Move down");
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("Move left");
        }
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("Move right");
        }
    }
}
