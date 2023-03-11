using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public float jump = 10f;
    public Vector2 startingPosition; // add a variable to store the starting position of the player

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startingPosition = transform.position; // set the starting position to the current position of the player
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");

        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
    }

    // add a method to reset the player position
    void ResetPlayerPosition()
    {
        transform.position = startingPosition;
    }

    // called when the player collides with a trigger collider
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            ResetPlayerPosition(); // reset the player position
        }
    }
}
