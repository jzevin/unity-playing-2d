using UnityEngine;

// from: https://www.youtube.com/@sasquatchbgames
// Transform Translation:
// Pros
// You’ll have EXTREMELY precise control over movement, acceleration, collisions, and everything
// You don’t need a Rigidbody (unless you want to call OnTriggerEnter2D, then you need a kinematic RB and collider)
// Cons
// More setup as you have to create your own collision detection
// Does not work with physics forces (ex. RB.AddForce)
// Notes:
// Use in Update
// Multiply by Time.deltaTime to get consistent speed

public class TransformTranslate : MonoBehaviour
{
    
    public Vector3 direction = Vector3.right;
    public float speed = 1.0f;
    public int initialPosition = -8;
    public int finalPosition = 8;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < finalPosition - 1)
        {
            
            transform.Translate(direction * speed * Time.deltaTime);
        } else {
            transform.position = new Vector3(finalPosition - 1, transform.position.y, transform.position.z);
        }
    }

    public void OnReset()
    {
        transform.position = new Vector3(initialPosition, transform.position.y, transform.position.z);
    }
}
