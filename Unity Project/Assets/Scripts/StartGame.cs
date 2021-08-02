using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Rigidbody ballBody;
    [SerializeField] PlatformControl platform;

    public static bool GameActive = false;

    public void StartButtonPressed()
    {
        GameActive = true;
        platform.CalibrateAccelerometer();
        GameStarted();
    }

    private void GameStarted()
    {
        this.gameObject.SetActive(false);
        ballBody.useGravity = true;
        timer.StartTimer();
    }
}
