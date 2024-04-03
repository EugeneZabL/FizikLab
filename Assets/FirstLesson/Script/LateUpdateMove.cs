using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateUpdateMove : MonoBehaviour
{
    [SerializeField] private float speed;
    void LateUpdate()
    {
        this.transform.Translate(0, 0, Time.deltaTime*speed);
    }
}
