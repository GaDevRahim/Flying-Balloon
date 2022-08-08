using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] GameObject[] objectPrefabs = new GameObject[2];
    int randomObject;

    Vector3 posi;
    float randomPosiX;
    float randomPosiY;

    float startTime, repeatTime;

    void Start()
    {
        startTime = 0.0f;
        repeatTime = 3.05f;
        InvokeRepeating("SpawnObject", startTime, repeatTime);
    }

    void SpawnObject()
    {
        if (!PlayerController.gameOver)
        {
            randomPosiX = Random.Range(22.0f, 26.0f);
            randomPosiY = Random.Range(5.0f, 15.0f);
            posi.Set(randomPosiX, randomPosiY, 0);
            randomObject = Random.Range(0, objectPrefabs.Length);
            Instantiate(objectPrefabs[randomObject], posi, objectPrefabs[randomObject].transform.rotation);
        }
    }
}
