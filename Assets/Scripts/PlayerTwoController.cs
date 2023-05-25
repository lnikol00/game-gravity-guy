using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerTwoController : MonoBehaviour
{
    private Rigidbody2D rb;
    private GameController gc;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        gc = GameObject.FindGameObjectWithTag("GameController").GetComponent<GameController>();  
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            rb.gravityScale *= -1;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            gc.GameOver();
        }
    }
}
