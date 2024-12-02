using UnityEngine;

// RB.Velocity
// Pros
// Extremely easy to setup
// Collisions work out of the gate
// Cons
// Overwrites physics forces (can make movement problems difficult to debug.)
// Notes
// Use in Update
// Does not need to be multiplied by Time.deltaTime.
// Set RB to ‘Interpolate’ for smooth movement

public class RBVelocity : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 direction = Vector2.right;
    public float speed = 1.0f;

    private int initialPosition;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = (int)transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        rb.linearVelocity = direction * speed;
    }

    public void OnReset()
    {
        transform.position = new Vector3(initialPosition, transform.position.y, transform.position.z);
    }
}