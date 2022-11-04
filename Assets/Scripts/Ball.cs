using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float MoveSpeed;

    Vector2 BallDirection = new Vector2(1, 1);
    private Vector3 direction;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;


        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(MoveSpeed, MoveSpeed,Time.deltaTime);
        //transform.Translate(BallDirection * MoveSpeed * Time.deltaTime);
        transform.Translate(direction * MoveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
        if (collision.gameObject.CompareTag("Paddle"))
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LeftBarrier"))
        {
            ResetBall();
            GameObject.FindObjectOfType<ScoreManager>().AddP2Score();
        }
        if (collision.gameObject.CompareTag("RightBarrier"))
        {
            ResetBall();
            GameObject.FindObjectOfType<ScoreManager>().AddP1Score();
        }
    }
    private void ResetBall()
    {
        transform.position = new Vector3(0, 0, 0);
        direction = new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), 0);
        direction = direction.normalized;
    }
}
