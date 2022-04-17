using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody playerRg;
    float force = 10;
    float gravityModifier = 1.3f;
    float maxYPosi = 13.5f;

    AudioSource playerSound;
    [SerializeField] AudioClip bombSound, moneySound, groundSound;

    [SerializeField] ParticleSystem fxBomb, fxMoney;

    internal static int score = 0;
    internal static bool gameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        playerRg = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;

        playerSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && transform.position.y < maxYPosi && !gameOver) 
        {
            playerRg.AddForce(Vector3.up * force, ForceMode.Impulse);
        }
        if (score == -1) gameOver = true;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Money"))
        {
            fxMoney.Play();
            playerSound.PlayOneShot(moneySound, 1.0f);
            score++;
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.CompareTag("Bomb"))
        {
            fxBomb.Play();
            playerSound.PlayOneShot(bombSound, 1.0f);
            Destroy(collision.gameObject);
            gameOver = true;
            Debug.Log("GameOver");
        }
        else if (collision.gameObject.CompareTag("Ground") && !gameOver) 
        {
            playerRg.AddForce(Vector3.up * (force / 2.0f), ForceMode.Impulse);
            playerSound.PlayOneShot(groundSound, 1.0f);
        }
    }
}
