using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPosi;
    float repeat;

    void Start()
    {
        startPosi = transform.position;
        repeat = GetComponent<BoxCollider>().size.x / 2.0f;
    }

    void Update()
    {
        if(transform.position.x < startPosi.x - repeat)
        {
            transform.position = startPosi;
        }
    }
}
