using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScreenController : MonoBehaviour
{
    // Loads the Selection Scene
    public void StartGame()
    {
        SceneManager.LoadScene("SelectScene");
    }

    // Loads the Visualizer Scene
    public void LoadVisualizer()
    {
        SceneManager.LoadScene("Visualizer");
    }
}
