using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Canvas gameOverMenu;
    [SerializeField] Rigidbody ballBody;


    private void OnTriggerEnter(Collider other)
    {
        StartGame.GameActive = false;
        gameOverMenu.gameObject.SetActive(true);
        ballBody.useGravity = false;
        ballBody.velocity = Vector3.zero;
        timer.StopTimer();
    }

    public void RestartButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void ExitButtonPressed()
    {
        Application.Quit();
    }
}
