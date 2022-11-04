using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public int playerNumber = 1;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0.0f;
    }

    void Update()
    {
        if (playerNumber == 1)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player1") * Time.deltaTime * 8.5f, 0));
        }
        if (playerNumber == 2)
        {
            transform.Translate(new Vector3(0, Input.GetAxis("Player2") * Time.deltaTime * 8.5f, 0));
        }
    }
}