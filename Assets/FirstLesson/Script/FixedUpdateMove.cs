﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateMove : MonoBehaviour
{
    [SerializeField] private float speed;
    void FixedUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime*speed);
    }
}
