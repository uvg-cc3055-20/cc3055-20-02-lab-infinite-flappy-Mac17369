using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float jumpForce = 200f;
    private Rigidbody2D rb;
    public double score;

	void Start () {
        rb = GetComponent<Rigidbody2D>();
    }
	
	void Update () {
        if (Input.GetButtonDown("Jump")) {
            rb.velocity = Vector2.zero;
            rb.AddForce(Vector2.up * jumpForce);
        }
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        Debug.Log("Puntos obtenidos: " + score);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameController.instance.gameOver = true;
    }
}
