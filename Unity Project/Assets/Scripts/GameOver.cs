using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Restart and Exit buttons function.
/// </summary>
public class GameOver : MonoBehaviour
{
    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }
}
