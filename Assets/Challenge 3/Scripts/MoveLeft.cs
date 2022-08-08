using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    [SerializeField] float speed;

    // Update is called once per frame
    void Update()
    {
        if (!PlayerController.gameOver) 
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);

        if (transform.position.x < -6 && !gameObject.CompareTag("Background")) 
        {
            if (gameObject.CompareTag("Money"))
                PlayerController.score--;
            Destroy(gameObject);
        }
    }
}
