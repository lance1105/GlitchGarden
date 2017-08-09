using UnityEngine;

public class LevelManager : MonoBehaviour {

    public float autoLoadNextLevelAfter;

    private void Start() {
        if (autoLoadNextLevelAfter == 0) {
            // Do nothing
        } else {
            Invoke("LoadNextLevel", autoLoadNextLevelAfter);
        }

    }

    // Load the game level
    public void LoadLevel(string name) {
        Application.LoadLevel(name);
    }

    // Quit the game
    public void QuitRequest() {
        Application.Quit();
    }

    // Load next level
    public void LoadNextLevel() {
        Application.LoadLevel(Application.loadedLevel + 1);
    }
}
