using UnityEngine;

public class LeapfrogTrigger : MonoBehaviour
{
    public string opponentTag; // Tag of the opponent player
    public int player1Score = 0; // Player 1's score
    public int player2Score = 0; // Player 2's score
    private bool hasJumped = false; // Flag to track if the player has jumped over the opponent
    private bool isGrounded = true; // Flag to track if the player is grounded

    void OnTriggerEnter(Collider other)
    {
        if (isGrounded && !hasJumped && other.CompareTag(opponentTag))
        {
            hasJumped = true; // Set flag to true to prevent multiple triggers
            if (other.gameObject.CompareTag("Player"))
            {
                player1Score++; // Increase Player 1's score
                Debug.Log("Player 1 jumped over the opponent! Player 1 score: " + player1Score);
            }
            else if (other.gameObject.CompareTag("Player2"))
            {
                player2Score++; // Increase Player 2's score
                Debug.Log("Player 2 jumped over the opponent! Player 2 score: " + player2Score);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (hasJumped && other.CompareTag(opponentTag))
        {
            hasJumped = false; // Reset flag when the player exits the opponent's collider
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true; // Set isGrounded to true when the player collides with the ground
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false; // Set isGrounded to false when the player leaves the ground
        }
    }
}
