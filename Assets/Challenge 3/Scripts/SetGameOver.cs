using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetGameOver : MonoBehaviour
{
    Text massage;

    // Start is called before the first frame update
    void Start()
    {
        massage = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (PlayerController.gameOver) massage.text = "Game \nOver !";
    }
}
