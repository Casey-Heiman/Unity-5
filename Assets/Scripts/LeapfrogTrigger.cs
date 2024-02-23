using UnityEngine;

public class LeapfrogTrigger : MonoBehaviour
{
    public string opponentTag; // Tag of the opponent player
    public int player1Score = 0; // Player 1's score
    public int player2Score = 0; // Player 2's score
    private bool hasJumped = false; // Flag to track if the player has jumped over the opponent
    private bool isGrounded = true; // Flag to track if the player is grounded


    public Collider player1collider;
    public Collider player2collider;
    public float cooldown = 1f;
    private float nextTriggerTime = 0f;
    private int player1JumpCount;
    private int player2JumpCount;



    void OnTriggerEnter(Collider other)
    {
        if (other == player2collider)
        {
            player1JumpCount++;
            Debug.Log("Player 1 jumped player 2 " + player1JumpCount + "times");
            // player1ScoreText.text = "Green: " + player1JumpCount;

        }
    }

}
