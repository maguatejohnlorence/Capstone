using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void StartGame()
    {
        // Save current scene name before switching
        PlayerPrefs.SetString("PreviousScene", SceneManager.GetActiveScene().name);

        // Load the game scene
        SceneManager.LoadScene("PlayerModeMenu");
    }

    public void GoBack()
    {
        string previousScene = PlayerPrefs.GetString("PreviousScene", "MainMenu");

        SceneManager.LoadScene(previousScene);
    }

    public void QuitGame()
    {
        Application.Quit();
        
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }
}

