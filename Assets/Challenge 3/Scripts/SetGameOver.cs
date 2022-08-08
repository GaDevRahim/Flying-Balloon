using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGameOver : MonoBehaviour
{
    Text massage;

    void Start()
    {
        massage = GetComponent<Text>();
    }

    void Update()
    {
        if (PlayerController.gameOver) massage.text = "Game \nOver !";
    }
}
