using UnityEngine;

public class PlatformControl : MonoBehaviour
{
    private const float SPEED_ROTATE = 250;

    [SerializeField] private float rotationLimit = 30f;
    private float xRotation;
    private float yRotation;

    private Quaternion calibrationQuaternion;


    void FixedUpdate()
    {
        if (StartGame.GameActive)
            MoveAcceleration();
    }

    private void MoveAcceleration()
    {
        Vector3 fixedAcceleration = FixAcceleration(Input.acceleration);

        xRotation += (-fixedAcceleration.x * SPEED_ROTATE) * Time.fixedDeltaTime;
        xRotation = Mathf.Clamp(xRotation, -rotationLimit, rotationLimit);

        yRotation += ((fixedAcceleration.y) * SPEED_ROTATE) * Time.fixedDeltaTime;
        yRotation = Mathf.Clamp(yRotation, -rotationLimit, rotationLimit);


        transform.rotation = Quaternion.Euler(yRotation, 0, xRotation);
    }

    public void CalibrateAccelerometer()
    {
        Quaternion rotateQuanternion = Quaternion.FromToRotation(new Vector3(0f, 0f, -1f),
                                                                 Input.acceleration);
        calibrationQuaternion = Quaternion.Inverse(rotateQuanternion);
    }

    private Vector3 FixAcceleration(Vector3 acceleration) => calibrationQuaternion * acceleration;
}
