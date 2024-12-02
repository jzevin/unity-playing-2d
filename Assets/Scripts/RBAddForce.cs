using UnityEngine;
using UnityEngine.Events;

// RB.AddForce
// Pros
// Collisions work right out of the gate
// Works well WITH physics forces
// Cons
// Not as precise as other methods. Not good for pixel-perfect platformers for example.
// More work to get consistent movement that isn’t too floaty up-front
// Notes:
// Use in FixedUpdate
// Does not need to be multiplied by Time.deltaTime.
// Set RB to ‘Interpolate’ for smooth movement
// You’ll likely need to set a maxSpeed of some kind, and acceleration/deceleration controls to get your character feeling less slippery.

public class RBAddForce : MonoBehaviour
{
    private Rigidbody2D rb;
    public Vector2 direction = Vector2.right;
    public float force = 1.0f;

    private int initialPosition;

     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = (int)transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(direction * force);
    }

    void MyAction()
    {
        Debug.Log("My Action");
    }

    public void OnReset()
    {
        transform.position = new Vector3(initialPosition, transform.position.y, transform.position.z);
    }
}
