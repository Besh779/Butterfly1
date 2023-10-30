using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int scoreValue = 1; // Score value when this item is collected

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            ScoreManager scoreManager = FindObjectOfType<ScoreManager>(); // Find the ScoreManager object
            if (scoreManager != null)
            {
                scoreManager.UpdateScore(scoreValue); // Update the score
            }

            Destroy(gameObject); // Remove the collectible
        }
    }
}
