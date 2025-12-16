using UnityEngine;

public class Rotation : MonoBehaviour
{
    // Kecepatan putar
    public float rotationSpeed = 5f; 

    void Update()
    {
        // === 1. LOGIKA UNTUK HP (SENTUHAN JARI) ===
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Moved)
            {
                // Di HP, deltaPosition biasanya nilainya kecil, jadi speed dikali biasa
                float deltaX = touch.deltaPosition.x;
                transform.Rotate(0, -deltaX * rotationSpeed * 0.1f, 0, Space.World);
            }
        }
        
        // === 2. LOGIKA UNTUK SIMULATOR/EDITOR (MOUSE) ===
        // Kode ini akan jalan kalau kamu Klik Kiri (0) dan Tahan
        else if (Input.GetMouseButton(0))
        {
            // Di Mouse, "Mouse X" adalah pergerakan mouse ke samping
            float deltaX = Input.GetAxis("Mouse X");
            
            // Di Editor, kita perlu pengali lebih besar karena pergerakan mouse dihitung beda
            // Kita kali 5 atau 10 biar lebih cepat
            transform.Rotate(0, -deltaX * rotationSpeed * 5f, 0, Space.World);
        }
    }
}