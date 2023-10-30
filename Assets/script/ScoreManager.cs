using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText; // Reference to the Text component to display the score
    private int score = 0;

    // Function to update the score by a certain value
    public void UpdateScore(int value)
    {
        score += value;
        UpdateScoreUI();
    }

    // Function to update the score display in the UI
    void UpdateScoreUI()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}

