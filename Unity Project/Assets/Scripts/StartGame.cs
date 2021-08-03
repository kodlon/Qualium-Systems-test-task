using UnityEngine;

public class StartGame : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Rigidbody ballBody;
    [SerializeField] PlatformControl platform;

    public static bool GameActive = false;


    /// <summary>
    /// Used to begin game. GameActive, calibrate, ball physics, timer.
    /// </summary>
    public void StartButtonPressed()
    {
        GameActive = true;
        platform.CalibrateAccelerometer();
        ballBody.useGravity = true;
        timer.StartTimer();

        this.gameObject.SetActive(false);
    }
}
