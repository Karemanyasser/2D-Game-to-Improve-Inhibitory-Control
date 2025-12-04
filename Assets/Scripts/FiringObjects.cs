using UnityEngine;

public class FiringObjects : MonoBehaviour
{
    public float fireRate = 0.2f;
    public Transform firingPoint;
    public GameObject objectPrefab;
    float timeUntilFire;    
    public float objectLifetime = 3.0f; // time until the object is destroyed
    GameObject fallenObject;

    private void Update()
    {
        if (timeUntilFire < Time.time)
        {
            Shoot();
            timeUntilFire = Time.time + fireRate;
            Destroy(fallenObject,objectLifetime);
        }
    }
    void Shoot()
    {
        float angle = 0f;
        // random position in x axis for the fired object
        int randomNumber = Random.Range(-7, 6);
        Vector3 randomPosition = firingPoint.position;
        randomPosition.x +=  randomNumber;

        fallenObject=Instantiate(objectPrefab, randomPosition, Quaternion.Euler(new Vector3(0f, 0f, angle)));

    }
}
