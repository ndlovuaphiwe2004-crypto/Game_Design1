using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public float speed = 5f; // Speed of the player movement

    private Vector2 movement; // Variable to store movement input
    
    // Update is called once per frame
    void Update()
    {
        // Get input from the horizontal and vertical axes (WASD or arrow keys)
        float input = Input.GetAxis("Horizontal");
        movement.x = input*speed*Time.deltaTime;
        // Move the player based on the input and speed
        transform.Translate(movement );
    }
}
