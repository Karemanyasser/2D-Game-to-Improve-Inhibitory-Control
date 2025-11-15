using Unity.VisualScripting;
using UnityEditor.Callbacks;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 15f;
    public float bulletDamage = 10f;
    public Rigidbody2D rb;
    private void FixedUpdate()
    {
        rb.linearVelocity = Vector2.up * bulletSpeed; // bullet spead and direction
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
         // Destroy the object that collided with
        Destroy(collision.gameObject);
    }

}
