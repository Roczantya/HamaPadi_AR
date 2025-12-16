using UnityEngine;

public class Rotasi : MonoBehaviour
{
    public float rotationSpeed = 10f;

    void Update()
    {
        // Hanya jalan jika ada sentuhan dan jari bergerak
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved)
        {
            Vector2 touchDelta = Input.GetTouch(0).deltaPosition;

            // Kita putar Local Rotation agar sumbunya tetap tegak lurus dengan lantai
            // Walaupun HP kamu miring-miring
            transform.Rotate(Vector3.up, -touchDelta.x * rotationSpeed * Time.deltaTime, Space.Self);
        }
    }
}
