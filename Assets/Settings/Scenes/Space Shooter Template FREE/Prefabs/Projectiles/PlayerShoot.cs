using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 0.25f;

    float fireTimer;
    PlayerMovement movement;

    void Awake()
    {
        movement = GetComponent<PlayerMovement>();
    }

    void Update()
    {
        fireTimer += Time.deltaTime;

        // 🚀 ĐANG DI CHUYỂN → AUTO FIRE
        if (movement != null && movement.isMoving)
        {
            TryShoot();
        }
        // 🖱️ ĐỨNG IM → BẤM CHUỘT MỚI BẮN
        else if (Input.GetMouseButton(0))
        {
            TryShoot();
        }
    }

    void TryShoot()
    {
        if (fireTimer >= fireRate)
        {
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            fireTimer = 0f;
        }
    }
}
