﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyboardDetect : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("Quit");
            Application.Quit();

        }

    }
}
