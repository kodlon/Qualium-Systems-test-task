using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Rigidbody ballBody;

    public static bool GameActive = false;

    public void StartButtonPressed()
    {
        GameActive = true;
        GameStarted();
    }

    private void GameStarted()
    {
        this.gameObject.SetActive(false);
        ballBody.useGravity = true;
        timer.StartTimer();
    }
}
