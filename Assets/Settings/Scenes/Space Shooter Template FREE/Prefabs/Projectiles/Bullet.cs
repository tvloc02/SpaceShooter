using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float flySpeed = 10f;

    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.y += Time.deltaTime * flySpeed;
        transform.position = newPosition;
    }
}
