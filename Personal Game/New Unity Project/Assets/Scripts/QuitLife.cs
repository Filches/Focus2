﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitLife : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Application.Quit();
            print("Hey you, you're finally awake.");
        }
    }
}
