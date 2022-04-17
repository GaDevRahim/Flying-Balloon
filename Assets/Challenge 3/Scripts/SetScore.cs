using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetScore : MonoBehaviour
{

    Text massage;

    float repeatTime = 0.2f;

    // Start is called before the first frame update
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
