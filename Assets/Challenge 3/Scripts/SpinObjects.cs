﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinObjects : MonoBehaviour
{
    public float spinSpeed;

    void Update()
    {
        transform.Rotate(0.0f, spinSpeed * Time.deltaTime, 0.0f, Space.Self);
    }
}
