using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdjump : MonoBehaviour


{
    public AudioSource jump;
    public AudioSource score;
    public AudioSource death;
    public Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            float jumpVelocity = 8f;
            rigidbody2d.velocity = Vector2.up * jumpVelocity;
            jump.Play();
        }
        
        if(text.score == 5)
        {
            SceneManager.LoadScene("Game 1");
        }

        if(SceneManager.GetActiveScene().name == "Game 1")
        {
            pipemovement.speed = 10;
        }

    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.name == "pipe"){
           death.Play();
           Invoke("Startgame",0.6f);
        }

    }
    private void OnTriggerEnter2D(Collider2D other) {
        score.Play();
        text.score ++;
    }

    void Startgame()
    {
            SceneManager.LoadScene("Game");
    }
}