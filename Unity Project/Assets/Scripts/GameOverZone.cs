using UnityEngine;

public class GameOverZone : MonoBehaviour
{
    [SerializeField] Timer timer;
    [SerializeField] Canvas gameOverMenu;


    /// <summary>
    /// Used to end game. GameActive, ball freezing, timer.
    /// </summary>
    private void OnTriggerEnter(Collider other)
    {
        StartGame.GameActive = false;
        gameOverMenu.gameObject.SetActive(true);

        Rigidbody ballBody = other.GetComponent<Rigidbody>();
        ballBody.useGravity = false;
        ballBody.velocity = Vector3.zero;

        timer.StopTimer();
    }
}
