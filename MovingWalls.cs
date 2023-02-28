using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingWalls : MonoBehaviour
{
    public float speed;
    public bool isVertical;
    public bool isHorizontal;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if (isHorizontal)
            rb.velocity = new Vector2(speed, rb.velocity.y);

        if (isVertical)
            rb.velocity = new Vector2(rb.velocity.x, speed);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("mPoint"))
            speed *= -1;

    }
}


