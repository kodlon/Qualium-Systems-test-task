using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    private const float SPEED_ROTATE = 150;

    float xRotation = 0;
    float yRotation = 0;


    void FixedUpdate()
    {
        MoveAcceleration();
    }

    private void MoveAcceleration()
    {
        float xAxis = Input.acceleration.x;
        float yAxis = Input.acceleration.y;

        yRotation += (yAxis * SPEED_ROTATE) * Time.fixedDeltaTime;
        yRotation = Mathf.Clamp(yRotation, -30f, 30f);

        xRotation += (xAxis * SPEED_ROTATE) * Time.fixedDeltaTime;
        xRotation = Mathf.Clamp(xRotation, -30f, 30f);

        transform.rotation = Quaternion.Euler(yRotation, 0, -xRotation);
    }
}
