using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void PlayGame()
    {
        // Load the game scene (replace "GameScene" with your game scene name)
        SceneManager.LoadScene("SampleScene");
    }

    public void QuitGame()
    {
        // Quit the application
        Debug.Log("Quit Game"); // This works in the editor to indicate quitting
        Application.Quit();
    }
}
