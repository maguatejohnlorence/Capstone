using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMode : MonoBehaviour
{
    // Assign these in the Inspector with the names of your scenes
    public string SoloScene = "SoloScene";
    public string MultiScene = "MultiScene";

    // Call this method when the Solo button is clicked
    public void OnSoloButtonClicked()
    {
        SceneManager.LoadScene(SoloScene);
    }

    // Call this method when the Multiplayer button is clicked
    public void OnMultiButtonClicked()
    {
        SceneManager.LoadScene(MultiScene);
    }
}