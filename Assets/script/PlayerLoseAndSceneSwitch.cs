using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLoseAndSceneSwitch : MonoBehaviour
{
    public string loseSceneName; // Name of the scene to load when the player loses
    public float loseHeight = -5f; // Height at which the player is considered to have lost
    private bool playerHasLost = false;

    private void Update()
    {
        if (transform.position.y < loseHeight && !playerHasLost)
        {
            // Player has lost - switch to the lose scene
            playerHasLost = true;
            SceneManager.LoadScene(5);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if the collision is with an object tagged as "Floor"
        if (collision.gameObject.CompareTag("Floor"))
        {
            // Player has lost - switch to the lose scene
            playerHasLost = true;
            SceneManager.LoadScene(2);
        }
    }
}
