using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneToLoad; // The name of the scene to switch to

    public void SwitchToScene()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
