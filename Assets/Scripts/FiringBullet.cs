using UnityEngine;

public class FiringBullet : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject bulletPrefab;
    float timeUntilFire;
    public float bulletLifetime = 3.0f; // time until the bullet is destroyed
    GameObject shotBullet;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && timeUntilFire < Time.time)
        {
            Shoot();
            timeUntilFire = Time.time + fireRate;
            Destroy(shotBullet,bulletLifetime);
        }
    }
    void Shoot()
    {
        float angle = 0f;
        shotBullet = Instantiate(bulletPrefab, firingPoint.position, Quaternion.Euler(new Vector3(0f, 0f, angle)));

    }
}
