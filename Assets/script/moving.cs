using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 5f;
    public float moveSpeed = 2f; // Speed for horizontal movement
    public float forwardSpeed = 2f; // Speed for forward and backward movement
    private bool isDead = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Check for jump input
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (!isDead)
            {
                Jump();
            }
        }

        // Check for movement input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (!isDead)
        {
            Move(moveHorizontal, moveVertical);
        }
    }

    void Jump()
    {
        rb.velocity = Vector3.up * jumpForce;
    }

    void Move(float moveHorizontal, float moveVertical)
    {
        // Calculate the movement direction
        Vector3 movement = new Vector3(moveHorizontal * moveSpeed, 0f, moveVertical * forwardSpeed);

        // Apply the movement to the player
        rb.velocity = new Vector3(movement.x, rb.velocity.y, movement.z);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            Die();
        }
    }

    void Die()
    {
        isDead = true;
        // Handle player death here
        Debug.Log("Player has died!");
        // Add any additional logic for player death
    }
}
