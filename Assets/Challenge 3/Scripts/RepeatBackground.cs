using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    Vector3 startPosi;
    float repeat;

    // Start is called before the first frame update
    void Start()
    {
        startPosi = transform.position;
        repeat = GetComponent<BoxCollider>().size.x / 2.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x < startPosi.x - repeat)
        {
            transform.position = startPosi;
        }
    }
}
