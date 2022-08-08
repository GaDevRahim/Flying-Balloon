using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{
    Text massage;

    float repeatTime = 0.2f;

    void Start()
    {
        massage = GetComponent<Text>();

        InvokeRepeating("SetText", 0.0f, repeatTime);
    }

    void SetText()
    {
        massage.text = "Score : " + PlayerController.score;
    }
}
