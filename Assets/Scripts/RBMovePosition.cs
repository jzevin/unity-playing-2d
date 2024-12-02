using UnityEngine;

// RB.MovePosition
// Pros
// Precise control over movement, acceleration
// Collisions work right out of the gate
// Cons
// Conflicts with physics forces
// Notes:
// Use in FixedUpdate
// Multiply by Time.deltaTime to get consistent speed
// Set RB to ‘Interpolate’ for smooth movement

public class RBMovePosition : MonoBehaviour
{
    public float speed = 1.0f;
    private Rigidbody2D rb;

    private int initialPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = (int)transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.right * speed * Time.fixedDeltaTime);
    }

    public void OnReset()
    {
        transform.position = new Vector3(initialPosition, transform.position.y, transform.position.z);
    }
}
