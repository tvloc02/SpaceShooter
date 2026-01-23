using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 5f;

    [HideInInspector]
    public bool isMoving;

    Vector3 lastPosition;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePos.z = 0;

        transform.position = Vector3.Lerp(
            transform.position,
            mousePos,
            speed * Time.deltaTime
        );

        // ✅ PHÁT HIỆN DI CHUYỂN (KHÔNG ĐIỀU KHIỂN)
        isMoving = Vector3.Distance(transform.position, lastPosition) > 0.001f;
        lastPosition = transform.position;
    }
}
